using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr21team24finalproject.DAL;
using spr21team24finalproject.Models;
using Microsoft.AspNetCore.Authorization;


namespace spr21team24finalproject.Controllers
{
    public class AlbumReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public AlbumReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AlbumReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlbumReviews.ToListAsync());
        }

        // GET: AlbumReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumReview = await _context.AlbumReviews
                .FirstOrDefaultAsync(m => m.AlbumReviewID == id);
            if (albumReview == null)
            {
                return NotFound();
            }

            return View(albumReview);
        }

        // GET: AlbumReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlbumReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlbumReviewID,AlbumAvgScore,AlbumScoreInput,AlbumScoreCount,AlbumScoreSum,AlbumComment")] AlbumReview albumReview)
        {
            if (ModelState.IsValid)
            {
                albumReview.AlbumReviewStatusType = AlbumReviewStatus.Pending;
                _context.Add(albumReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(albumReview);
        }

        [Authorize(Roles = "Manager, Employee")]
        public async Task<IActionResult> Approve(int id)
        {
            AlbumReview albumReview = _context.AlbumReviews
                                        .Include(ar => ar.Album).ThenInclude(a => a.Songs).ThenInclude(a => a.Artist)
                                        .Include(sr => sr.AppUser).FirstOrDefault(ar => ar.AlbumReviewID == id);

            albumReview.AlbumReviewStatusType = AlbumReviewStatus.Approved;

            _context.Add(albumReview);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Albums");

        }

        // GET: AlbumReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumReview = await _context.AlbumReviews.FindAsync(id);
            if (albumReview == null)
            {
                return NotFound();
            }
            return View(albumReview);
        }

        // POST: AlbumReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumReviewID,AlbumAvgScore,AlbumScoreInput,AlbumScoreCount,AlbumScoreSum,AlbumComment")] AlbumReview albumReview)
        {
            if (id != albumReview.AlbumReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumReviewExists(albumReview.AlbumReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(albumReview);
        }

        // GET: AlbumReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumReview = await _context.AlbumReviews
                .FirstOrDefaultAsync(m => m.AlbumReviewID == id);
            if (albumReview == null)
            {
                return NotFound();
            }

            return View(albumReview);
        }

        // POST: AlbumReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var albumReview = await _context.AlbumReviews.FindAsync(id);
            _context.AlbumReviews.Remove(albumReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumReviewExists(int id)
        {
            return _context.AlbumReviews.Any(e => e.AlbumReviewID == id);
        }
    }
}

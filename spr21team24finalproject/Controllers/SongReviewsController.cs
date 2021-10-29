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
    public class SongReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public SongReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SongReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.SongReviews.ToListAsync());
        }

        // GET: SongReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songReview = await _context.SongReviews
                .FirstOrDefaultAsync(m => m.SongReviewID == id);
            if (songReview == null)
            {
                return NotFound();
            }

            return View(songReview);
        }

        // GET: SongReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SongReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongReviewID,SongAvgRating,SongRating,SongRatingCount,SongRatingSum,SongComment")] SongReview songReview)
        {
            
            if (ModelState.IsValid)
            {
                songReview.SongReviewStatusType = SongReviewStatus.Pending;
                _context.Add(songReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(songReview);
        }

        [Authorize(Roles = "Manager, Employee")]
        public async Task<IActionResult> Approve(int id)
        {
            SongReview songReview = _context.SongReviews
                                        .Include(sr => sr.Song).ThenInclude(s => s.Album).ThenInclude(a => a.Artist)
                                        .Include(sr => sr.AppUser).FirstOrDefault(sr => sr.SongReviewID == id);

            songReview.SongReviewStatusType = SongReviewStatus.Approved;

            _context.Add(songReview);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Songs");

        }

        // GET: SongReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songReview = await _context.SongReviews.FindAsync(id);
            if (songReview == null)
            {
                return NotFound();
            }
            return View(songReview);
        }

        // POST: SongReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongReviewID,SongAvgRating,SongRating,SongRatingCount,SongRatingSum,SongComment")] SongReview songReview)
        {
            if (id != songReview.SongReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongReviewExists(songReview.SongReviewID))
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
            return View(songReview);
        }

        // GET: SongReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songReview = await _context.SongReviews
                .FirstOrDefaultAsync(m => m.SongReviewID == id);
            if (songReview == null)
            {
                return NotFound();
            }

            return View(songReview);
        }

        // POST: SongReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songReview = await _context.SongReviews.FindAsync(id);
            _context.SongReviews.Remove(songReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongReviewExists(int id)
        {
            return _context.SongReviews.Any(e => e.SongReviewID == id);
        }
    }
}

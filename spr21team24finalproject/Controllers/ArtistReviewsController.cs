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
    public class ArtistReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ArtistReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ArtistReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArtistReviews.ToListAsync());
        }

        // GET: ArtistReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistReview = await _context.ArtistReviews
                .FirstOrDefaultAsync(m => m.ArtistReviewID == id);
            if (artistReview == null)
            {
                return NotFound();
            }

            return View(artistReview);
        }

        // GET: ArtistReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtistReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtistReviewID,ArtistAvgRating,ArtistRating,ArtistScoreCount,ArtistScoreSum,ArtistComment")] ArtistReview artistReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artistReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artistReview);
        }

        // GET: ArtistReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistReview = await _context.ArtistReviews.FindAsync(id);
            if (artistReview == null)
            {
                return NotFound();
            }
            return View(artistReview);
        }

        // POST: ArtistReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtistReviewID,ArtistAvgRating,ArtistRating,ArtistScoreCount,ArtistScoreSum,ArtistComment")] ArtistReview artistReview)
        {
            if (id != artistReview.ArtistReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artistReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistReviewExists(artistReview.ArtistReviewID))
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
            return View(artistReview);
        }

        // GET: ArtistReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistReview = await _context.ArtistReviews
                .FirstOrDefaultAsync(m => m.ArtistReviewID == id);
            if (artistReview == null)
            {
                return NotFound();
            }

            return View(artistReview);
        }

        // POST: ArtistReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artistReview = await _context.ArtistReviews.FindAsync(id);
            _context.ArtistReviews.Remove(artistReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistReviewExists(int id)
        {
            return _context.ArtistReviews.Any(e => e.ArtistReviewID == id);
        }
    }
}

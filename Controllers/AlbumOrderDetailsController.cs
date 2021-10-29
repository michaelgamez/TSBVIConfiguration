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
    [Authorize]
    public class AlbumOrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public AlbumOrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AlbumOrderDetails
        public IActionResult Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }
            List<AlbumOrderDetail> aod = _context.AlbumOrderDetails
                                          .Include(aod => aod.Album)
                                          .Where(od => od.Order.OrderID == orderID)
                                          .ToList();
            return View(aod);
        }


        // GET: AlbumOrderDetails/AddAlbumtoCart
        public IActionResult AddAlbumToCart(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify an album to add to cart!" });
            }

            //create a new instance of the OrderDetail class
            AlbumOrderDetail aod = new AlbumOrderDetail();

            //Find son on associated with order detail
            Album dbAlbum = _context.Albums.Find(id);

            if (dbAlbum == null)
            {
                return View("Error", new string[] { "Album not found in the database" });
            }
            aod.Album = dbAlbum;


            Order shoppingCart = _context.Orders.Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                         .Where(o => o.AppUser.UserName == User.Identity.Name)
                                         .FirstOrDefault();

            if (shoppingCart == null || shoppingCart.StatusType == Status.Completed)
            {
                Order newShoppingCart = new Order();

                // Associate the order with the logged-in customer
                newShoppingCart.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                //Find the next order number from the utilities class
                newShoppingCart.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);
                //Set the date of this order
                newShoppingCart.OrderDate = DateTime.Now;
                //Set order status
                newShoppingCart.StatusType = Status.Pending;
                //Set gift
                newShoppingCart.Gift = false;
                //Recipient Name
                //newShoppingCart.RecipientName = newShoppingCart.AppUser.UserName;
                

                _context.Orders.Add(newShoppingCart);
                _context.SaveChanges();

                aod.Order = newShoppingCart;
            }
            else
            {
                List<AlbumOrderDetail> currentaods = shoppingCart.AlbumOrderDetails.ToList();

                foreach (AlbumOrderDetail aod2 in currentaods)
                {
                    if (aod2.Album.AlbumID == aod.Album.AlbumID)
                    {
                        return View("Error", new string[] { "Duplicate album cannot be Added!" });
                    }
                }

                List<SongOrderDetail> currentsods = shoppingCart.SongOrderDetails.ToList();

                foreach (SongOrderDetail sod2 in currentsods)
                {
                    if (sod2.Song.Album != null)
                    {
                        if (sod2.Song.Album.AlbumID == aod.Album.AlbumID)
                        {
                            return View("Error", new string[] { "Album not added. One or more songs on selected album are already in cart!" });
                        }
                    }
                }

                aod.Order = shoppingCart;
            }

            _context.Add(aod);
            _context.SaveChanges();

            return RedirectToAction("ShoppingCart", "Orders", new { orderID = aod.Order.OrderID });
        }
        /*
        // GET: AlbumOrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumOrderDetail = await _context.AlbumOrderDetails
                .FirstOrDefaultAsync(m => m.AlbumOrderDetailID == id);
            if (albumOrderDetail == null)
            {
                return NotFound();
            }

            return View(albumOrderDetail);
        }
        */

        
        // GET: AlbumOrderDetails/Create
        public IActionResult Create(int orderID)
        {
            AlbumOrderDetail aod = new AlbumOrderDetail();

            //find the registration that should be associated with this registration
            Order dbOrder = _context.Orders.Find(orderID);

            //set the new registration detail's registration equal to the registration you just found
            aod.Order = dbOrder;

            //populate the ViewBag with a list of existing product
            ViewBag.AllAlbums = GetAllAlbums();

            //pass the newly created registration detail to the view
            return View(aod);
        }

        // POST: AlbumOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order, AlbumOrderDetailID,AlbumsOriginalPrice,AlbumPurchasePrice,AlbumTotalPrice")] AlbumOrderDetail albumOrderDetail, int SelectedAlbum)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProducts = GetAllAlbums();
                return View(albumOrderDetail);
            }
            //find the song to be associated with this order
            Album dbAlbum = _context.Albums.Find(SelectedAlbum);

            //set the song detail's product to be equal to the one we just found
            albumOrderDetail.Album = dbAlbum;

            //find the order on the database that has the correct order id
            //unfortunately, the HTTP request will not contain the entire order object, 
            //just the order id, so we have to find the actual object in the database
            Order dbOrder = _context.Orders.Find(albumOrderDetail.Order.OrderID);

            //set the order on the order detail equal to the order that we just found
            albumOrderDetail.Order = dbOrder;

            //set the song order detail's price equal to the price
            //this will allow us to to store the price that the user paid
            albumOrderDetail.AlbumPurchasePrice = dbAlbum.AlbumDiscountPrice;

            //calculate the extended price for the registration detail
            albumOrderDetail.AlbumTotalPrice = albumOrderDetail.Order.AlbumSubtotal;

            //add the registration detail to the database
            _context.Add(albumOrderDetail);
            await _context.SaveChangesAsync();

            //send the user to the details page for this registration
            return RedirectToAction("Details", "Orders", new { id = albumOrderDetail.Order.OrderID });

        }

        // GET: AlbumOrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumOrderDetail = await _context.AlbumOrderDetails.FindAsync(id);
            if (albumOrderDetail == null)
            {
                return NotFound();
            }
            return View(albumOrderDetail);
        }

        // POST: AlbumOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumOrderDetailID,AlbumsOriginalPrice,AlbumPurchasePrice,AlbumTotalPrice")] AlbumOrderDetail albumOrderDetail)
        {
            if (id != albumOrderDetail.AlbumOrderDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(albumOrderDetail);
            }

            AlbumOrderDetail dbAOD;
            //if code gets this far, update the record
            try
            {
                //find the existing song order detail in the database
                //include both order and song
                dbAOD = _context.AlbumOrderDetails
                      .Include(aod => aod.Album)
                      .Include(aod => aod.Order)
                      .FirstOrDefault(aod => aod.AlbumOrderDetailID == albumOrderDetail.AlbumOrderDetailID);

                //TODO: Useless
                ////update the scalar properties
                ////dbSOD.SongTotalPrice = orderDetail.Quantity;
                //dbSOD.SongOriginalPrice = dbSOD.SongOriginalPrice;
                //dbSOD.SongPurchasePrice = dbOD.Quantity * dbOD.ProductPrice;

                //save changes
                _context.Update(dbAOD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Orders", new { id = dbAOD.Order.OrderID });

        }

        // GET: AlbumOrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumOrderDetail = await _context.AlbumOrderDetails
                .FirstOrDefaultAsync(m => m.AlbumOrderDetailID == id);
            if (albumOrderDetail == null)
            {
                return NotFound();
            }

            return View(albumOrderDetail);
        }

        // POST: AlbumOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            AlbumOrderDetail albumOrderDetail = await _context.AlbumOrderDetails
                                                   .Include(o => o.Order)
                                                   .FirstOrDefaultAsync(o => o.AlbumOrderDetailID == id);

            _context.AlbumOrderDetails.Remove(albumOrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Orders", new { id = albumOrderDetail.Order.OrderID });
        }

        private bool AlbumOrderDetailExists(int id)
        {
            return _context.AlbumOrderDetails.Any(e => e.AlbumOrderDetailID == id);
        }

        private SelectList GetAllAlbums()
        {
            //create a list for all the songs
            List<Album> allAlbums = _context.Albums.ToList();

            //the user MUST select a song, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllAlbums = new SelectList(allAlbums, nameof(Album.AlbumID), nameof(Album.AlbumTitle));

            return slAllAlbums;
        }
    }
}

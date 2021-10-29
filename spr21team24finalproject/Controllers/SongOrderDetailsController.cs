using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using spr21team24finalproject.DAL;
using spr21team24finalproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace spr21team24finalproject.Controllers
{
    [Authorize]
    public class SongOrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public SongOrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SongOrderDetails
        public IActionResult Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //limit the list to only the order details that belong to this order
            List<SongOrderDetail> sod = _context.SongOrderDetails
                                          .Include(sod => sod.Song)
                                          .Where(od => od.Order.OrderID == orderID)
                                          .ToList();

            return View(sod);
        }

        /*
        // GET: SongOrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songOrderDetail = await _context.SongOrderDetails
                .FirstOrDefaultAsync(m => m.SongOrderDetailID == id);
            if (songOrderDetail == null)
            {
                return NotFound();
            }

            return View(songOrderDetail);
        }
        */

        // GET: SongOrderDetails/AddSongtoCart
        public IActionResult AddSongToCart(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a song to add to cart!" });
            }

            //create a new instance of the OrderDetail class
            SongOrderDetail sod = new SongOrderDetail();

            //Find son on associated with order detail
            Song dbSong = _context.Songs.Find(id);

            if (dbSong == null)
            {
                return View("Error", new string[] { "Song not found in the database" });
            }
            sod.Song = dbSong;


            Order shoppingCart = _context.Orders.Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                         .Where(o => o.AppUser.UserName == User.Identity.Name).Where(o => o.StatusType == Status.Pending)
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

                sod.Order = newShoppingCart;
            }
            else
            {
                List<SongOrderDetail> currentsods = shoppingCart.SongOrderDetails.ToList();

                foreach (SongOrderDetail sod2 in currentsods)
                {
                    if (sod2.Song.SongID == sod.Song.SongID)
                    {
                        return View("Error", new string[] { "Duplicate song cannot be added to cart" });
                    }
                }

                sod.Order = shoppingCart;
            }

            _context.Add(sod);
            _context.SaveChanges();

            return RedirectToAction("ShoppingCart", "Orders", new { orderID = sod.Order.OrderID });
        }



        //private bool SongOrderDetailExists(int id)
//        {
//            return _context.SongOrderDetails.Any(e => e.SongOrderDetailID == id);
//        }



        // POST: SongOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // SONG ADD TO ORDER
        public async Task<IActionResult> Create([Bind("SongOrderDetailID, SongOriginalPrice, Song, Order")] SongOrderDetail sod, int songID, int orderID)
        {
            Song dbSong = _context.Songs.Include(s => s.Album).FirstOrDefault(s => s.SongID == songID); 
            Order dbOrder = _context.Orders.Include(s => s.AppUser).FirstOrDefault(s => s.OrderID == orderID); //FirstOrDefault(s => s.StatusType == StatusType.Pending);
            //nd(songOrderDetail.Order.OrderID);

            sod.Song = dbSong;
            sod.Order = dbOrder;

            if(ModelState.IsValid == false)
            {
                System.Diagnostics.Debug.WriteLine("Model failed");
                return View();
            }

            _context.SongOrderDetails.Add(sod);

            await _context.SaveChangesAsync();

            //SongOrderDetail songOrderDetail = new SongOrderDetail
            //{
            //    SongOriginalPrice = song.SongOriginalPrice,
            //    SongPurchasePrice = song.SongDiscountPrice,
            //    Song = _context.Songs.Find(SongID)
            //};

            //if(order == null)
            //{
            //    Order dbOrder = new Order
            //    {
            //        StatusType = StatusType.Pending,
            //        AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name),
            //        OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context),
            //        OrderDate = DateTime.Now

            //    };
            //    _context.Add(dbOrder);
            //    await _context.SaveChangesAsync();

            //    songOrderDetail.Order = _context.Orders.Find(dbOrder.OrderID);
            //}

            ////if user has not entered all fields, send them back to try again
            //if (ModelState.IsValid == false )
            //{
            //    ViewBag.AllSongs = GetAllSongs();
            //    return View(songOrderDetail);
            //}

            //else /*(ModelState.IsValid)*/
            //{
            //    //find the song to be associated with this order

            //    //set the song detail's product to be equal to the one we just found
            //    songOrderDetail.Song = dbSong;
            //    //find the order on the database that has the correct order id
            //    //unfortunately, the HTTP request will not contain the entire order object, 
            //    //just the order id, so we have to find the actual object in the database
            //    Order dbOrder = _context.Orders.Find(songOrderDetail.Order.OrderID);

            //    //set the order on the order detail equal to the order that we just found
            //    songOrderDetail.Order = dbOrder;

            //    //set the song order detail's price equal to the price
            //    //this will allow us to to store the price that the user paid
            //    //TODO: prices change
            //    songOrderDetail.SongPurchasePrice = dbSong.SongDiscountPrice;

            //    //calculate the extended price for the registration detail
            //    songOrderDetail.SongTotalPrice = songOrderDetail.Order.SongSubtotal;

            //    _context.Add(songOrderDetail);
            //    await _context.SaveChangesAsync();
                
            //}

            // return View("Confirmed", new String[] { "Item has been added to cart!" });

            //return View("Error", new String[] { "This method is not working (songorderdetails/create)!" });


            //send the user to the details page for this registration

            return RedirectToAction("Checkout", "Orders", new { id = sod.Order.OrderID });
        }

        // GET: SongOrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songOrderDetail = await _context.SongOrderDetails.FindAsync(id);
            if (songOrderDetail == null)
            {
                return NotFound();
            }
            return View(songOrderDetail);
        }

        // POST: SongOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongOrderDetailID,SongOriginalPrice,SongPurchasePrice,SongTotalPrice")] SongOrderDetail songOrderDetail)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != songOrderDetail.SongOrderDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(songOrderDetail);
            }

            //create a new song order detail
            SongOrderDetail dbSOD;
            //if code gets this far, update the record
            try
            {
                //find the existing song order detail in the database
                //include both order and song
                dbSOD = _context.SongOrderDetails
                      .Include(sod => sod.Song)
                      .Include(sod => sod.Order)
                      .FirstOrDefault(sod => sod.SongOrderDetailID == songOrderDetail.SongOrderDetailID);

                //TODO: Useless
                ////update the scalar properties
                ////dbSOD.SongTotalPrice = orderDetail.Quantity;
                //dbSOD.SongOriginalPrice = dbSOD.SongOriginalPrice;
                //dbSOD.SongPurchasePrice = dbOD.Quantity * dbOD.ProductPrice;

                //save changes
                _context.Update(dbSOD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Orders", new { id = dbSOD.Order.OrderID });
        }

        // GET: SongOrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songOrderDetail = await _context.SongOrderDetails
                .FirstOrDefaultAsync(m => m.SongOrderDetailID == id);
            if (songOrderDetail == null)
            {
                return NotFound();
            }

            return View(songOrderDetail);
        }

        // POST: SongOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //find the registration detail to delete
            SongOrderDetail songOrderDetail = await _context.SongOrderDetails
                                                   .Include(o => o.Order)
                                                   .FirstOrDefaultAsync(o => o.SongOrderDetailID == id);

            //delete the registration detail
            _context.SongOrderDetails.Remove(songOrderDetail);
            await _context.SaveChangesAsync();

            //return the user to the registration/details page
            return RedirectToAction("Details", "Orders", new { id = songOrderDetail.Order.OrderID });
        }

        //private bool SongOrderDetailExists(int id)
        //{
        //    return _context.SongOrderDetails.Any(e => e.SongOrderDetailID == id);
        //}

        private SelectList GetAllSongs()
        {
            //create a list for all the songs
            List<Song> allSongs = _context.Songs.ToList();

            //the user MUST select a song, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllSongs = new SelectList(allSongs, nameof(Song.SongID), nameof(Song.SongTitle));

            return slAllSongs;
        }
    }
}

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using spr21team24finalproject.DAL;
//using spr21team24finalproject.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


//namespace spr21team24finalproject.Controllers
//{
//    [Authorize]
//    public class SongOrderDetailsController : Controller
//    {
//        private readonly AppDbContext _context;

//        public SongOrderDetailsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: SongOrderDetails
//        public IActionResult Index(int? orderID)
//        {
//            if (orderID == null)
//            {
//                return View("Error", new String[] { "Please specify a order to view!" });
//            }

//            //limit the list to only the order details that belong to this order
//            List<SongOrderDetail> sod = _context.SongOrderDetails
//                                          .Include(sod => sod.Song)
//                                          .Include(sod => sod.Song.Artist)
//                                          .Include(sod => sod.Order)
//                                          .Where(od => od.Order.OrderID == orderID)
//                                          .ToList();

//            return View(sod);
//        }

//        /*
//        // GET: SongOrderDetails/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var songOrderDetail = await _context.SongOrderDetails
//                .FirstOrDefaultAsync(m => m.SongOrderDetailID == id);
//            if (songOrderDetail == null)
//            {
//                return NotFound();
//            }

//            return View(songOrderDetail);
//        }
//        */

//        // GET: SongOrderDetails/Create
//        public IActionResult Create(int orderID)
//        {
//            //create a new instance of the OrderDetail class
//            SongOrderDetail sod = new SongOrderDetail();

//            //find the registration that should be associated with this registration
//            Order dbOrder = _context.Orders.Find(orderID);

//            //set the new registration detail's registration equal to the registration you just found
//            sod.Order = dbOrder;

//            //populate the ViewBag with a list of existing product
//            ViewBag.AllSongs = GetAllSongs();
//            //if()
//            //{
//            //}
//            //else
//            //{
//            //    sod.SongOriginalPrice = dbSong.OriginalPrice;
//            //}

//            //pass the newly created registration detail to the view
//            return View(sod); 
//        }

//        // POST: SongOrderDetails/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        // SONG ADD TO ORDER
//        public async Task<IActionResult> Create([Bind("SongOrderDetailID, SongOriginalPrice, Song, Order")] SongOrderDetail sod, int songID, int orderID)
//        {
//            Song dbSong = _context.Songs.Include(s => s.Album).FirstOrDefault(s => s.SongID == songID); 
//            Order dbOrder = _context.Orders.Include(s => s.AppUser).FirstOrDefault(s => s.OrderID == orderID); //FirstOrDefault(s => s.StatusType == StatusType.Pending);
//            //nd(songOrderDetail.Order.OrderID);

//            sod.Song = dbSong;
//            sod.Order = dbOrder;

//            if(ModelState.IsValid == false)
//            {
//                System.Diagnostics.Debug.WriteLine("Model failed");
//                return View();
//            }

//            _context.SongOrderDetails.Add(sod);

//            await _context.SaveChangesAsync();

//            //SongOrderDetail songOrderDetail = new SongOrderDetail
//            //{
//            //    SongOriginalPrice = song.SongOriginalPrice,
//            //    SongPurchasePrice = song.SongDiscountPrice,
//            //    Song = _context.Songs.Find(SongID)
//            //};

//            //if(order == null)
//            //{
//            //    Order dbOrder = new Order
//            //    {
//            //        StatusType = StatusType.Pending,
//            //        AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name),
//            //        OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context),
//            //        OrderDate = DateTime.Now

//            //    };
//            //    _context.Add(dbOrder);
//            //    await _context.SaveChangesAsync();

//            //    songOrderDetail.Order = _context.Orders.Find(dbOrder.OrderID);
//            //}

//            ////if user has not entered all fields, send them back to try again
//            //if (ModelState.IsValid == false )
//            //{
//            //    ViewBag.AllSongs = GetAllSongs();
//            //    return View(songOrderDetail);
//            //}

//            //else /*(ModelState.IsValid)*/
//            //{
//            //    //find the song to be associated with this order

//            //    //set the song detail's product to be equal to the one we just found
//            //    songOrderDetail.Song = dbSong;
//            //    //find the order on the database that has the correct order id
//            //    //unfortunately, the HTTP request will not contain the entire order object, 
//            //    //just the order id, so we have to find the actual object in the database
//            //    Order dbOrder = _context.Orders.Find(songOrderDetail.Order.OrderID);

//            //    //set the order on the order detail equal to the order that we just found
//            //    songOrderDetail.Order = dbOrder;

//            //    //set the song order detail's price equal to the price
//            //    //this will allow us to to store the price that the user paid
//            //    //TODO: prices change
//            //    songOrderDetail.SongPurchasePrice = dbSong.SongDiscountPrice;

//            //    //calculate the extended price for the registration detail
//            //    songOrderDetail.SongTotalPrice = songOrderDetail.Order.SongSubtotal;

//            //    _context.Add(songOrderDetail);
//            //    await _context.SaveChangesAsync();
                
//            //}

//            // return View("Confirmed", new String[] { "Item has been added to cart!" });

//            //return View("Error", new String[] { "This method is not working (songorderdetails/create)!" });


//            //send the user to the details page for this registration

//            return RedirectToAction("Create", "Orders", new { id = sod.Order.OrderID });
//        }

//        // GET: SongOrderDetails/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var songOrderDetail = await _context.SongOrderDetails.FindAsync(id);
//            if (songOrderDetail == null)
//            {
//                return NotFound();
//            }
//            return View(songOrderDetail);
//        }

//        // POST: SongOrderDetails/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("SongOrderDetailID,SongOriginalPrice,SongPurchasePrice,SongTotalPrice")] SongOrderDetail songOrderDetail)
//        {
//            //this is a security check to make sure they are editing the correct record
//            if (id != songOrderDetail.SongOrderDetailID)
//            {
//                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
//            }

//            //information is not valid, try again
//            if (ModelState.IsValid == false)
//            {
//                return View(songOrderDetail);
//            }

//            //create a new song order detail
//            SongOrderDetail dbSOD;
//            //if code gets this far, update the record
//            try
//            {
//                //find the existing song order detail in the database
//                //include both order and song
//                dbSOD = _context.SongOrderDetails
//                      .Include(sod => sod.Song)
//                      .Include(sod => sod.Order)
//                      .FirstOrDefault(sod => sod.SongOrderDetailID == songOrderDetail.SongOrderDetailID);

//                //TODO: Useless
//                ////update the scalar properties
//                ////dbSOD.SongTotalPrice = orderDetail.Quantity;
//                //dbSOD.SongOriginalPrice = dbSOD.SongOriginalPrice;
//                //dbSOD.SongPurchasePrice = dbOD.Quantity * dbOD.ProductPrice;

//                //save changes
//                _context.Update(dbSOD);
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
//            }

//            //if code gets this far, go back to the registration details index page
//            return RedirectToAction("Details", "Orders", new { id = dbSOD.Order.OrderID });
//        }

//        // GET: SongOrderDetails/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var songOrderDetail = await _context.SongOrderDetails
//                .FirstOrDefaultAsync(m => m.SongOrderDetailID == id);
//            if (songOrderDetail == null)
//            {
//                return NotFound();
//            }

//            return View(songOrderDetail);
//        }

//        // POST: SongOrderDetails/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            //find the registration detail to delete
//            SongOrderDetail songOrderDetail = await _context.SongOrderDetails
//                                                   .Include(o => o.Order)
//                                                   .FirstOrDefaultAsync(o => o.SongOrderDetailID == id);

//            //delete the registration detail
//            _context.SongOrderDetails.Remove(songOrderDetail);
//            await _context.SaveChangesAsync();

//            //return the user to the registration/details page
//            return RedirectToAction("Details", "Orders", new { id = songOrderDetail.Order.OrderID });
//        }

//        
//        private SelectList GetAllSongs()
//        {
//            //create a list for all the songs
//            List<Song> allSongs = _context.Songs.ToList();

//            //the user MUST select a song, so you don't need a dummy option for no course

//            //use the constructor on select list to create a new select list with the options
//            SelectList slAllSongs = new SelectList(allSongs, nameof(Song.SongID), nameof(Song.SongTitle));

//            return slAllSongs;
//        }
//    }
//}
//>>>>>>> Stashed changes

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
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public IActionResult Index()
        {
            List<Order> orders;

            if (User.IsInRole("Manager, Employee"))
            {
                orders = _context.Orders.Include(o => o.SongOrderDetails)
                                        .Include(o => o.AlbumOrderDetails)
                                        .ToList();
            }
            else //user is a customer
            {
                orders = _context.Orders.Include(o => o.SongOrderDetails)
                                        .Include(o => o.AlbumOrderDetails) //may be ord => ord.
                                        .Where(o => o.AppUser.UserName == User.Identity.Name)
                                        .ToList();
            }

            return View(orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify a irder to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //find the order in the database
            Order order =_context.Orders.Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                         .Include(o => o.AppUser).FirstOrDefault(o => o.OrderID == id);

            //order was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure this order belongs to this user
            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!" });
            }

            //TODO: Not included
            //order.CalcTotals()

            //Send the user to the details page
            return View(order);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult ShoppingCart(int? orderID)
        {
            Order shoppingCart = _context.Orders
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                         .Include(o => o.AppUser).FirstOrDefault(o => o.OrderID == orderID);

            return View(shoppingCart);
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }


        // GET: Orders/Create
        [Authorize(Roles = "Customer")]
        //TODO: Authorization should be done in the view for employees and managers //[Bind("OrderID,OrderNumber,OrderDate,StatusType")] 
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize(Roles = "Customer")]//Only thing should orderID
        //public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,StatusType")] Order order, int SongID, int AlbumID)
        //{
        //    //Find the next order number from the utilities class
        //    order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

        //    //Set the date of this order
        //    order.OrderDate = DateTime.Now;


        //    // Associate the order with the logged-in customer
        //    order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

        //    //make sure all properties are valid
        //    if (ModelState.IsValid == false)
        //    {
        //        return View(order);
        //    }

        //    // if code gets this far, add the order to the database
        //    //TODO: Update Status type to pending
        //    order.StatusType = Status.Pending;

        //    _context.Add(order);

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("OrderSummary", "Orders", new { orderID = order.OrderID });

        //    // return RedirectToAction(nameof(OrderSummary));
        //}

        // GET: Billing and Delivery
        public IActionResult BillingAndDelivery(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify an order!" });
            }

            Order billingAndDelivery = _context.Orders
                                        .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                        .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                        .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                        .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                        .Include(o => o.AppUser).FirstOrDefault(o => o.OrderID == id);



            return View(billingAndDelivery);

        }

        // Post: Billing and Delivery
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BillingAndDelivery([Bind("OrderID, Gift, GiftRecipientEmail, CreditCard, StatusType")] Order order)
        {

            if (order.Gift == true && order.GiftRecipientEmail == null)
            {
                return View(order);
            }

            if (order.Gift == true && order.GiftRecipientEmail != null)
            {
                AppUser dbUser = _context.Users.Find(order.GiftRecipientEmail);

                if (dbUser == null)
                {
                    return View("Error", new string[] { "Recipient not found in database!" });
                }

                try
                {
                    order.GiftRecipientEmail = dbUser.Email;
                    //Need to figure out how to send songs to orders

                }
                catch (Exception ex)
                {
                    return View("Error", new string[] { "There was an error!", ex.Message });
                }
            }
            
       
                Order dbOrder = _context.Orders.Find(order.OrderID);

                //dbOrder.SongOrderDetails.Sum(rd => rd.SongPurchasePrice);
                //dbOrder.SongOrderDetails.Sum(rd => rd.SongPurchasePrice);

                dbOrder.StatusType = Status.Completed;

                order = dbOrder;

                order.OrderNumber = dbOrder.OrderNumber;

                order.OrderDate = dbOrder.OrderDate;

                order.Gift = dbOrder.Gift;
            //changes!

                _context.Update(order);

                await _context.SaveChangesAsync();

            if (order.Gift == true && order.GiftRecipientEmail != null)
                { 
                String toemail = order.GiftRecipientEmail;
                String emailsubject = "You have been sent a gift!";
                String messagebody = "Enjoy your gift!";

                Utilities.SendEmail.SendMessage(toemail, emailsubject, messagebody);
                }
            else
            {
                order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                String toemail = order.AppUser.Email;
                String emailsubject = "You order has been placed.";
                String messagebody = "Thank you for placing an order. View it in your library";

                Utilities.SendEmail.SendMessage(toemail, emailsubject, messagebody);
            }
            return RedirectToAction("FinalCheckout", "Orders", new { orderID = order.OrderID });
        }


        public IActionResult FinalCheckout(int orderID)
        {
            Order order = _context.Orders.Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Artist)
                                         .Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.AlbumReviews)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.Artist)
                                         .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song).ThenInclude(s => s.SongReviews)
                                         .Include(o => o.AppUser).FirstOrDefault(o => o.OrderID == orderID);

            return View(order);
        }

       






        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]

        ////[Authorize(Roles = "Customer")]
        ////public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,StatusType")] Order order, int SongID, int AlbumID)
        ////{
        //send the user on to the action that will allow them to 
        // create a order detail.  Be sure to pass along the OrderID
        // that you created when you added the order to the database above
        // return RedirectToAction("Details", "Order", new { orderID = order.OrderID });

        ////    //Find the next order number from the utilities class
        ////    order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

        ////    //Set the date of this order
        ////    order.OrderDate = DateTime.Now;


        ////   // Associate the order with the logged-in customer
        ////    order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

        ////    //make sure all properties are valid
        ////    if (ModelState.IsValid == false)
        ////    {
        ////        return View(order);
        ////    }

        ////   // if code gets this far, add the order to the database
        ////    //TODO: Update Status type to pending
        ////    order.StatusType = Status.Pending;

        ////    _context.Add(order);

        ////    await _context.SaveChangesAsync();

        ////    //send the user on to the action that will allow them to 
        ////   // create a order detail.  Be sure to pass along the OrderID
        ////   // that you created when you added the order to the database above
        ////    //return RedirectToAction("Create", "SongOrderDetails", new { orderID = order.OrderID });

        ////    return RedirectToAction(nameof(Billing));



        //    // return View("You made it", new String[] { "orders contoller create method!" });

        //    //if (ModelState.IsValid == false)
        //    //{
        //    //    ViewBag.AllSongs = GetAllSongs();
        //    //    return RedirectToAction("Create", "SongOrderDetails", new { orderID = order.OrderID });

        //    //    //return View(songOrderDetail);
        //    //}
        //    ////item summary
        //    //// then 
        //    ////if (ModelState.IsValid)
        //    //{
        //    //    try
        //    //    {
        //    //        //find the order on the database that has the correct order id
        //    //        //unfortunately, the HTTP request will not contain the entire order object, 
        //    //        //just the order id, so we have to find the actual object in the database
        //    //        Order dbOrder = _context.Orders.Find(songOrderDetail.Order.OrderID);

        //    //        //set the order on the order detail equal to the order that we just found
        //    //        songOrderDetail.Order = dbOrder;

        //    //        //set the song order detail's price equal to the price
        //    //        //this will allow us to to store the price that the user paid
        //    //        songOrderDetail.SongPurchasePrice = dbSong.SongDiscountPrice;

        //    //        //calculate the extended price for the registration detail
        //    //        songOrderDetail.SongTotalPrice = songOrderDetail.Order.SongSubtotal;

        //    //        _context.Add(songOrderDetail);
        //    //        await _context.SaveChangesAsync();
        //    //        return View("Confirmed", new String[] { "Item has been added to cart!" });

        //    //    }
        //    //    catch (DbUpdateConcurrencyException)
        //    //    {
        //    //        if (!SongOrderDetailExists(songOrderDetail.SongOrderDetailID))
        //    //        {
        //    //            return View("Error", new String[] { "Item already in cart!" });
        //    //        }
        //    //        else
        //    //        {
        //    //            throw;
        //    //        }
        //    //    }
        //    //}
        //    ////Find the next order number from the utilities class
        //    //order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

        //    ////Set the date of this order
        //    //order.OrderDate = DateTime.Now;


        //    ////Associate the order with the logged-in customer
        //    //order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

        //    ////make sure all properties are valid
        //    //if (ModelState.IsValid == false)
        //    //{
        //    //    return View(order);
        //    //}

        //    ////if code gets this far, add the order to the database
        //    ////TODO: Update Status type to pending
        //    //order.StatusType = Status.Pending;

        //    //_context.Add(order);

        //    //await _context.SaveChangesAsync();

        //    ////send the user on to the action that will allow them to 
        //    ////create a order detail.  Be sure to pass along the OrderID
        //    ////that you created when you added the order to the database above
        //    //return RedirectToAction("Create", "SongOrderDetails", new { orderID = order.OrderID });
        //}

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to edit" });
            }

            Order order = await _context.Orders
                                             .Include(r => r.SongOrderDetails)
                                             .ThenInclude(r => r.Song)
                                             .Include(r => r.AlbumOrderDetails)
                                             .ThenInclude(r => r.Album)
                                             .Include(r => r.AppUser)
                                             .FirstOrDefaultAsync(m => m.OrderID == id);

            if (order == null)
            {
                return View("Error", new String[] { "Order not found!" });
            }

            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this order!" });
            }

            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderNumber,OrderDate,StatusType")] Order order)
        {
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order!" });
            }

            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Orders.Find(order.OrderID);

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Index));
        }

        //public IActionResult Checkout()
        //{
        //    //return RedirectToAction(nameof(Index));
        //    return RedirectToAction(nameof(OrderSummary));
        //}
     
        ////get checkout
        ////TODO: not ours. 
        //public IActionResult Checkout(int orderID)
        //{
        //    Order order = _context.Orders.Include(o => o.AlbumOrderDetails).ThenInclude(aod => aod.Album).ThenInclude(a => a.Songs)
        //                                 .Include(o => o.SongOrderDetails).ThenInclude(sod => sod.Song)
        //                                 .Include(o => o.AppUser).FirstOrDefault(o => o.OrderID == orderID);



        //    //order.CalcTotals();

        //    //AppUser user = new AppUser();

        //    //user = order.AppUser;

        //    /* need to have an account disabled we need this property but we don't
        //    if(AppUser.AcctDisabled == true)
        //    {
        //        return View("Error", new string[] { "Your account is disabled!" });
        //    }
        //    */

        //    List<Song> allSongs = new List<Song>();

        //    if (order.AlbumOrderDetails != null)
        //    {
        //        List<AlbumOrderDetail> aods = order.AlbumOrderDetails;
        //        foreach (AlbumOrderDetail aod in aods)
        //        {
        //            Album album = aod.Album;
        //            foreach (Song song in album.Songs)
        //            {
        //                allSongs.Add(song);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return View("Error");
        //    }

        //    if(order.SongOrderDetails != null)
        //    {
        //        List<SongOrderDetail> sods = order.SongOrderDetails;

        //        foreach (SongOrderDetail sod in sods)
        //        {
        //            allSongs.Add(sod.Song);
        //        }
        //    }
   

        //    IEnumerable<Song> duplicates = allSongs.GroupBy(x => x)
        //                                    .Where(g => g.Count() > 1)
        //                                    .Select(x => x.Key);

        //    string duplicateSongs = "You cannot check out! Remove the following duplicated songs:";

        //    foreach (Song song in duplicates)
        //    {
        //        System.Diagnostics.Debug.WriteLine("Duplicate song:" + song.SongTitle);
        //        duplicateSongs += ",";
        //    }

        //    var anyDuplicates = allSongs.GroupBy(x => x.SongTitle).Any(g => g.Count() > 1);

        //    if (anyDuplicates == true)
        //    {
        //        ViewBag.duplicateSongs = duplicateSongs;
        //        ViewBag.anyDuplicates = anyDuplicates;

        //        return View("Details", order);
        //    }

        //    ViewBag.duplicateSongs = duplicateSongs;
        //    ViewBag.duplicateSongs = anyDuplicates;

        //    return View(order);
        //}

       

        private SelectList GetAllSongs()
        {
            //create a list for all the courses
            List<Song> allSongs = _context.Songs.ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllSong = new SelectList(allSongs, nameof(Song.SongID), nameof(Song.SongTitle));

            return slAllSong;
        }
        /*
        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        //private bool OrderExists(int id)
        //{
        //    return _context.Orders.Any(e => e.OrderID == id);
        //}
    }
}

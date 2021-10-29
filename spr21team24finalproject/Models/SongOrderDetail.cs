using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    public class SongOrderDetail //: Order
    {

        public Int32 SongOrderDetailID { get; set; }

        //[Display(Name = "Quantity:")]
        //public Int32 Quantity { get; set; }

        public Decimal SongOriginalPrice { get; set; } 
        
        public Decimal SongPurchasePrice { get; set; } 
        //if a song is discounted, this purchase will be different than the original or regular price
        public Decimal SongTotalPrice { get; set; }


        public Order Order { get; set; }
        //public Song Song { get; set; }

        public Song Song { get; set; }

        //public SongOrderDetail()
        //{

        //    //if (Songs == null)
        //    //{
        //    //    Songs = new List<Song>();
        //    //}
        //}
        ////public void CalculateSongTotalPrice()
        ////{
        //    SongTotalPrice =  * SongPrice;

        //}
        //public void CalculateSongOriginalPrice()
        //{
        //    SongTotalPrice = Quantity * SongPrice;

        //}

    }
}
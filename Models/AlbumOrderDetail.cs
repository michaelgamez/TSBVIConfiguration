using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    public class AlbumOrderDetail //: Order
    {

        public Int32 AlbumOrderDetailID { get; set; }

        //[Display(Name = "Quantity:")]
        //public Int32 Quantity { get; set; }

        public Decimal AlbumsOriginalPrice { get; set; }

        public Decimal AlbumPurchasePrice { get; set; }
        //if a song is discounted, this purchase will be different than the original or regular price
        public Decimal AlbumTotalPrice { get; set; }


        public Order Order { get; set; }
        //public List<Album> Albums { get; set; }

        public Album Album { get; set; }

        //public AlbumOrderDetail()
        //{

        //    if (Albums == null)
        //    {
        //        Albums = new List<Album>();
        //    }
        //}
        //public void CalculateAlbumTotalPrice()
        //{
            //for each loop???
            //SongTotalPrice = Quantity * SongPrice;
            //for (Album)
            //{
            //    return AlbumTotalPrice;
            //}
        //}
       // public void CalculateAlbumOriginalPrice()
        //{
            //SongTotalPrice = Quantity * SongPrice;

       // }

    }
}
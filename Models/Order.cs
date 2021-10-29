using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace spr21team24finalproject.Models
{
    public enum Status { Completed, Pending, Cancelled }
    public class Order
    {
        const Decimal SALES_TAX_RATE = 0.0825m; // constant for sales tax rate (8.75%)

        public Int32 OrderID { get; set; }

        [Display(Name = "Order Number:")]
        //[Range(minimum: 70001, maximum: Int32.MaxValue, ErrorMessage = "The Order Number must be greater than 70001.")]
        public Int32 OrderNumber { get; set; }


        [Display(Name = "Order Date:")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Status:")]
        public Status StatusType { get; set; }

        public Boolean Gift { get; set; }

        [Display(Name = "Gift Recipient Email:")]
        public String GiftRecipientEmail { get; set; }

        [Display(Name = "Credit Card:")]
        [DataType(DataType.CreditCard)]
        [RegularExpression(@"\b(?:\d[ -]*?){13,16}\b", ErrorMessage = "Incorrect Credit Card Format")]
        public string CreditCard { get; set; }

        public Decimal SongSubtotal
        {
            get {return SongOrderDetails.Sum(rd => rd.Song.SongDiscountPrice); }
        }

        public Decimal AlbumSubtotal
        {
            get {return AlbumOrderDetails.Sum(rd => rd.Album.AlbumDiscountPrice); }
        }

        [Display(Name = "Order Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return SongSubtotal+AlbumSubtotal; }
        }

        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal*SALES_TAX_RATE; }
        }

        [Display(Name = "Order Total:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }


        public List<SongOrderDetail> SongOrderDetails { get; set; }
        public List<AlbumOrderDetail> AlbumOrderDetails { get; set; }

        public AppUser AppUser { get; set; }

        public Order()
        {
            if (SongOrderDetails == null)
            {
                SongOrderDetails = new List<SongOrderDetail>();
            }
            if (AlbumOrderDetails == null)
            {
                AlbumOrderDetails = new List<AlbumOrderDetail>();
            }
        }

    }
}

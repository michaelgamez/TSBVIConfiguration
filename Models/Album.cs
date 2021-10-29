using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace spr21team24finalproject.Models
{
    public class Album
    {
        public Int32 AlbumID { get; set; }

        //should we include artist name, albumrating and genre?


        [Display(Name = "Album Title:")]
        public String AlbumTitle { get; set; }


        [Display(Name = "Original Album Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AlbumOriginalPrice { get; set; }

        [Display(Name = "Discount Album Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AlbumDiscountPrice { get; set; }

        //navigational property for artist, genre, and album rating

        public Artist Artist { get; set; }

        public Genre Genre { get; set; }
        //public AlbumRating ARating { get; set; }

        public List<Song> Songs { get; set; }

        [Display(Name = "Album Reviews:")]
        public List<AlbumReview> AlbumReviews { get; set; }

        public List<AlbumOrderDetail> AlbumOrderDetails { get; set; }

        [Display(Name = "Album Average Rating:")]
        public Decimal AlbumAvgRating
        {
            get
            {
                if (AlbumReviews.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return (decimal)AlbumReviews.Average(sr => sr.AlbumRating);
                }
            }
        }


        public Album()
        {
            if (Songs == null)
            {
                Songs = new List<Song>();
            }
            if (AlbumReviews == null)
            {
                AlbumReviews = new List<AlbumReview>();
            }
            if (AlbumOrderDetails == null)
            {
                AlbumOrderDetails = new List<AlbumOrderDetail>();
            }
        }

    }
}

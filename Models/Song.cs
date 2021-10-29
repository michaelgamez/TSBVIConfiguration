using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    public class Song 
    {
        public Int32 SongID { get; set; }
       
        [Display(Name = "Song Title:")]
        public String SongTitle { get; set; }


        [Display(Name = "Original Song Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SongOriginalPrice { get; set; }

        [Display(Name = "Song Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SongDiscountPrice{ get; set; }


        //when Rating model class gets created add this in
        public Album Album { get; set; }

        public Artist Artist { get; set; }

        public Genre Genre { get; set; }

        //public List<Song> Songs { get; set; }

        public List<SongReview> SongReviews { get; set; }

        //TODO: Is this how this should work? Should we pass the avg rating to the 
        [Display(Name = "Song Rating:")]
        [Range(minimum: 1.0, maximum: 5.0)]
        public Decimal SongAvgRating
        {
            get
            {
                if (SongReviews.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return (decimal)SongReviews.Average(sr => sr.SongRating);
                }
            }
        }

        public List<SongOrderDetail> SongOrderDetails { get; set; }

        public Song()
        {

            if (SongReviews == null)
            {
                SongReviews = new List<SongReview>();
            }
            if (SongOrderDetails == null)
            {
                SongOrderDetails = new List<SongOrderDetail>();
            }
        }

        /*public void RestoreOriginalPrice()
        {
            SongDiscountPrice = SongOriginalPrice; 
        }*/
    }
}

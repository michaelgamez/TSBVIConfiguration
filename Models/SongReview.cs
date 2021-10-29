using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace spr21team24finalproject.Models
{
    public enum SongReviewStatus { Approved, Pending }

    public class SongReview
    {

        public Int32 SongReviewID { get; set; }

        ////TODO: DO not need??
        //[Display(Name = "Average Rating of Song:")] 
        //public Int32 SongAvgRating { get; set; }
       

        [Display(Name = "Song Rating:")]
        public Int32 SongRating { get; set; }

        //TODO: Do not need?
        public Int32 SongRatingCount { get; set; }

        public Int32 SongRatingSum { get; set; }
  
        [Display(Name = "Song Review Comment:")] 
        public String SongComment { get; set; }

        [Display(Name ="Song Review Status:")]
        public SongReviewStatus SongReviewStatusType { get; set; }

        //navigational property for user review
        public AppUser AppUser { get; set; }

        public Song Song { get; set; }


        //TODO: I am not sure that we need this at all
        //public void SongCalcScore()
        //{
        //    SongRatingCount = SongRatingCount + 1;
        //    SongRatingSum = SongRatingSum + SongRating;
        //    SongAvgRating = SongRatingSum / SongRatingCount;

        //}
       
    }
}

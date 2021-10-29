using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace spr21team24finalproject.Models
{
    public enum ArtistReviewStatus { Approved, Pending }

    public class ArtistReview
    {
        public Int32 ArtistReviewID { get; set; }
        //public Int32 ArtistAvgRating { get; set; }

        [Display(Name = "Artist Score:")]
        public Int32 ArtistRating { get; set; }
        public Int32 ArtistScoreCount { get; set; }
        public Int32 ArtistScoreSum { get; set; }

        [Display(Name = "Artist Review Comment:")]
        public String ArtistComment { get; set; }

        [Display(Name = "Artist Review Status:")]
        public ArtistReviewStatus ArtistReviewStatusType { get; set; }

        //navigational property for user review
        public AppUser AppUser { get; set; }
        public Artist Artist { get; set; }

        //public void ArtistCalcScore()
        //{
        //    ArtistScoreCount = ArtistScoreCount + 1;
        //    ArtistScoreSum = ArtistScoreSum + ArtistRating;
        //    ArtistAvgRating = ArtistScoreSum / ArtistScoreCount;

        //}
    }
}

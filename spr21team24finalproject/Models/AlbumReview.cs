using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    public enum AlbumReviewStatus { Approved, Pending }

    public class AlbumReview
    {
        public Int32 AlbumReviewID { get; set; }

        //[Display(Name = "Album Average Rating:")]
        //public Int32 AlbumAvgRating { get; set; }

        [Display(Name = "Album Rating:")]
        public Int32 AlbumRating { get; set; }
        public Int32 AlbumScoreCount { get; set; }
        public Int32 AlbumScoreSum { get; set; }

        [Display(Name = "Album Review:")]
        public String AlbumComment { get; set; }

        [Display(Name = "Album Review Status:")]
        public AlbumReviewStatus AlbumReviewStatusType { get; set; }

        //navigational property for user review
        public AppUser AppUser { get; set; }
        public Album Album { get; set; }

        //public void AlbumCalcScore()
        //{
        //    AlbumScoreCount = AlbumScoreCount + 1;
        //    AlbumScoreSum = AlbumScoreSum + AlbumRating;
        //    AlbumAvgRating = AlbumScoreSum / AlbumScoreCount;

        //}
    }
}

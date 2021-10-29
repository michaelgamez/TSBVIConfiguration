using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    public class Artist
    {
        public Int32 ArtistID { get; set; }

        [Display(Name = "Artist  Name:")]
        public String ArtistName { get; set; }

        public List<Album> Albums { get; set; }

        public List<Song> Songs { get; set; }

        public List<ArtistReview> ArtistReviews { get; set; }

        [Display(Name = "Average Artist Rating:")]
        public Decimal ArtistAvgRating
        {
            get
            {
                if (ArtistReviews.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    return (decimal)ArtistReviews.Average(sr => sr.ArtistRating);
                }
            }
        }

        public Artist()
        {
            if (Albums == null)
            {
                Albums = new List<Album>();
            }

            if (Songs == null)
            {
                Songs = new List<Song>();
            }

            if (ArtistReviews == null)
            {
                ArtistReviews = new List<ArtistReview>();
            }

            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace spr21team24finalproject.Models
{
    public enum SearchRatingType { lessThan, greaterThan }

    public class SearchViewModel
    {
        [Display(Name = "Search by Song Title:")]
        public string SearchSongTitle { get; set; }

        [Display(Name = "Search by Album Title:")]
        public string SearchAlbumTitle { get; set; }

        [Display(Name = "Search by Artist Name:")]
        public string SearchArtistName{ get; set; }

        [Display(Name = "Search by Genre:")]
        public Int32 SearchGenre { get; set; }

        [Display(Name = "Type of Search:")]
        public SearchRatingType? SearchRatingType { get; set; }

        [Display(Name = "Search by Rating:")]
        [Range(minimum: 1.0, maximum: 5.0, ErrorMessage = "The rating has to be a valid number from 1.0 to 5.0!")]
        public Decimal? SearchAvgRating { get; set; }
         
    }

}

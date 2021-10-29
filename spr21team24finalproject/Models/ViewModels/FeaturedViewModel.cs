using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;


namespace spr21team24finalproject.Models
{
    [Authorize (Roles = "Manager")]
    public class FeaturedViewModel
    {
        [Display(Name = "Song Title: ")]
        public string SongTitle { get; set; }

        [Display(Name = "Album Title: ")]
        public string AlbumTitle { get; set; }

    }
}

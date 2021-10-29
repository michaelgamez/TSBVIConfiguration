using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace spr21team24finalproject.Models
{
    //No Controller
    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre:")]
        public String GenreName { get; set; }

        //Genre is assigned to songs and albums
        //public List<Song> Songs { get; set; }
        //public List<Artist> Artists { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        public Genre()
        {
            if (Albums == null)
            {
                Albums = new List<Album>();
            }
            if (Songs == null)
            {
                Songs = new List<Song>();
            }
        }
    }
}

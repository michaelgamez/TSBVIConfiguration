using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace spr21team24finalproject.Models
{
    //public enum AccountType
    //{
    //    [Display(Name = "Employee")] Employee,
    //    [Display(Name = "Customer")] Customer,
    //    [Display(Name = "Manager")] Manager
    //}
    public class AppUser : IdentityUser 
    {
        //public AccountType Account { get; set; }

        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        [Display(Name = "Address:")]
        public String Address { get; set; }

        [Display(Name = "Zip Code:")]
        public String ZipCode { get; set; }

      
        public List<AlbumReview> AlbumReviews { get; set; }
        public List<ArtistReview> ArtistReviews { get; set; }
        public List<SongReview> SongReviews { get; set; }

        public List<Order> Orders { get; set; }

        public AppUser()
        {
            if (AlbumReviews == null)
            {
                AlbumReviews = new List<AlbumReview>();
            }
            if (ArtistReviews == null)
            {
                ArtistReviews = new List<ArtistReview>();
            }
            if (SongReviews == null)
            {
                SongReviews = new List<SongReview>();
            }
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
        }

    }
}

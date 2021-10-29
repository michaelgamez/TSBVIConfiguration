using System;
using Microsoft.EntityFrameworkCore; 

//TODO: Update this using statement to include your project name
using spr21team24finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace spr21team24finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        //TODO: Add Dbsets here.  Products is included as an example.  
        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<SongOrderDetail> SongOrderDetails { get; set; }
        public DbSet<AlbumOrderDetail> AlbumOrderDetails { get; set; }
        public DbSet<AlbumReview> AlbumReviews{ get; set; }
        public DbSet<ArtistReview> ArtistReviews { get; set; }
        public DbSet<SongReview> SongReviews { get; set; }



    }
}

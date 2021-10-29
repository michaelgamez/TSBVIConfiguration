using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO:Make these namespaces match your project name
using spr21team24finalproject.Models;
using spr21team24finalproject.DAL;
using System.Text;

//TODO: Upddate this namespace to match your project name
namespace spr21team24finalproject.Seeding
{
    public static class SeedAlbums
    {
        public static void SeedAllAlbums(AppDbContext db)
        {
            List<Album> AllAlbums = new List<Album>();
            AllAlbums.Add(new Album
            {
                AlbumTitle = "Future Nostalgia",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "21",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 10.99m,
                AlbumDiscountPrice = 10.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Torches",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Hands All Over",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "folklore",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                AlbumOriginalPrice = 12.99m,
                AlbumDiscountPrice = 12.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Nothing But the Beat",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Born This Way",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 14.99m,
                AlbumDiscountPrice = 14.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Loud",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Red River Blue (Deluxe Version)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                AlbumOriginalPrice = 11.99m,
                AlbumDiscountPrice = 11.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Pink Friday (Deluxe Version)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                AlbumOriginalPrice = 14.99m,
                AlbumDiscountPrice = 14.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Watch the Throne (Deluxe Version)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                AlbumOriginalPrice = 14.99m,
                AlbumDiscountPrice = 14.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Plastic Hearts",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 11.99m,
                AlbumDiscountPrice = 11.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "The Band Perry",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "When the Sun Goes Down",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Own the Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                AlbumOriginalPrice = 10.99m,
                AlbumDiscountPrice = 10.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "A Moment Apart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                AlbumOriginalPrice = 4.99m,
                AlbumDiscountPrice = 4.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Chaos and the Calm",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                AlbumOriginalPrice = 10.99m,
                AlbumDiscountPrice = 10.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Ceremonials (Deluxe Version)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + The Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                AlbumOriginalPrice = 10.99m,
                AlbumDiscountPrice = 10.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "If You're Reading This It's Too Late",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                AlbumOriginalPrice = 12.99m,
                AlbumDiscountPrice = 12.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "The Best of Bobby McFerrin",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                AlbumOriginalPrice = 9.99m,
                AlbumDiscountPrice = 9.99m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "Eat Randy - Single",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Julian Smith"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
                AlbumOriginalPrice = 1.29m,
                AlbumDiscountPrice = 1.29m,
            });

            AllAlbums.Add(new Album
            {
                AlbumTitle = "The Duck Song (The Duck and the Lemonade Stand)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bryant Oden"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Children's Music"),
                AlbumOriginalPrice = 1.29m,
                AlbumDiscountPrice = 1.29m,
            });


            //create a counter and flag to help with debugging
            int intAlbumID = 0;
            String strAlbumTitle = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Artists
                foreach (Album seedAlbum in AllAlbums)
                {
                    //updates the counters to get info on where the problem is
                    intAlbumID = seedAlbum.AlbumID;
                    strAlbumTitle = seedAlbum.AlbumTitle;

                    //try to find the Artist in the database
                    Album dbAlbum = db.Albums.FirstOrDefault(c => c.AlbumTitle == seedAlbum.AlbumTitle);

                    //if the Artist isn't in the database, dbArtist will be null
                    if (dbAlbum == null)
                    {
                        //add the Artist to the database
                        db.Albums.Add(seedAlbum);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbAlbum.AlbumTitle = seedAlbum.AlbumTitle;
                        dbAlbum.Artist = seedAlbum.Artist;
                        dbAlbum.Genre = seedAlbum.Genre;
                        dbAlbum.AlbumOriginalPrice = seedAlbum.AlbumOriginalPrice;
                        

                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)  //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strAlbumTitle);
                msg.Append(" Album (AlbumID = ");
                msg.Append(intAlbumID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above.  The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }
}

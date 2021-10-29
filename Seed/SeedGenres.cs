using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO:Make these namespaces match your project name
using spr21team24finalproject.Models;
using spr21team24finalproject.DAL;
using System.Text;


namespace spr21team24finalproject.Seeding
{
    public static class SeedGenres
    {
        public static void SeedAllGenres(AppDbContext db)
        {
            List<Genre> AllGenres = new List<Genre>();

            AllGenres.Add(new Genre
            {
                GenreName = "Pop",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Alternative",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Dance",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Country",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Rap",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Holiday",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Rock",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "J-Pop",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Classical",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Soundtrack",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Progressive Trance",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Comedy",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Children's Music",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Hip Hop",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Nu Metal",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Folk",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Reggae",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "House",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "Indie",
            });

            AllGenres.Add(new Genre
            {
                GenreName = "R&B",
            });

            //create a counter and flag to help with debugging
            int intGenreID = 0;
            String strGenreName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Artists
                foreach (Genre seedGenre in AllGenres)
                {
                    //updates the counters to get info on where the problem is
                    intGenreID = seedGenre.GenreID;
                    strGenreName = seedGenre.GenreName;

                    //try to find the Artist in the database
                    Genre dbGenre = db.Genres.FirstOrDefault(c => c.GenreName == seedGenre.GenreName);

                    //if the Artist isn't in the database, dbArtist will be null
                    if (dbGenre == null)
                    {
                        //add the Artist to the database
                        db.Genres.Add(seedGenre);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbGenre.GenreName = seedGenre.GenreName;
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
                msg.Append(strGenreName);
                msg.Append(" Genre (GenreID = ");
                msg.Append(intGenreID);
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

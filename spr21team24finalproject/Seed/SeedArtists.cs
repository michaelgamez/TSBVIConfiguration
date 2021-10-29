using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Make these namespaces match your project name
using spr21team24finalproject.Models;
using spr21team24finalproject.DAL;
using System.Text;

//Update this namespace to match your project name
namespace spr21team24finalproject.Seeding
{
    public class SeedArtists
    {
        public static void SeedAllArtists(AppDbContext db)
        {
            List<Artist> AllArtists = new List<Artist>();

            AllArtists.Add(new Artist
            {
                ArtistName = "Adele",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Alexandra Stan",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Ariana Grande",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Blake Shelton",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Bobby McFerrin",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Bryant Oden",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Calvin Harris & Rihanna",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Carly Rae Jepsen",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Chevelle",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Childish Gambino",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "David Guetta & Usher",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Drake",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Dua Lipa",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Ella Mai",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Florence + the Machine",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Foster the People",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Frank Ocean",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Hot Chelle Rae",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Hozier",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Jake Owen",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "James Bay",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Jessie J",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Julian Smith",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Kanye West & Jay Z",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Kendrick Lamar",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "King Krule",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lady Antebellum",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lady GaGa",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lady Gaga & Bradley Cooper",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lil Nas X",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lizzo",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Luis Fonsi & Daddy Yankee",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Lukas Graham",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Mark Ronson",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Maroon 5",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Martin Solveig & Dragonette",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Mike Posner",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Miley Cyrus",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Miranda Lambert",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Nick Jonas",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Nickelback",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Nicki Minaj",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Odesza",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "One Direction",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Pitbull",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Rick Ross",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Rihanna",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Roscoe Dash",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Sean Paul",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Selena Gomez & the Scene",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Sheck Wes",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Sia",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "St. Vincent",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Taylor Swift",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "The Band Perry",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "The Weeknd",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Travis Scott",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Waka Flocka Flame",
            });

            AllArtists.Add(new Artist
            {
                ArtistName = "Wale"
            });

            //create a counter and flag to help with debugging
            int intArtistID = 0;
            String strArtistName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Artists
                foreach (Artist seedArtist in AllArtists)
                {
                    //updates the counters to get info on where the problem is
                    intArtistID = seedArtist.ArtistID;
                    strArtistName = seedArtist.ArtistName;

                    //try to find the Artist in the database
                    Artist dbArtist = db.Artists.FirstOrDefault(a => a.ArtistName == seedArtist.ArtistName);

                    //if the Artist isn't in the database, dbArtist will be null
                    if (dbArtist == null)
                    {
                        //add the Artist to the database
                        db.Artists.Add(seedArtist);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbArtist.ArtistName = seedArtist.ArtistName;
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
                msg.Append(strArtistName);
                msg.Append(" Artist (ArtistID = ");
                msg.Append(intArtistID);
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

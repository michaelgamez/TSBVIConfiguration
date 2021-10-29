using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Make these namespaces match your project name
using spr21team24finalproject.Models;
using spr21team24finalproject.DAL;
using System.Text;

namespace spr21team24finalproject.Seeding  

{
    public static class SeedArtistReviews
    {
        public static void SeedAllArtistReviews(AppDbContext db)
        {
            List<ArtistReview> AllArtistReviews = new List<ArtistReview>();

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "elowe@netscrape.net"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                ArtistRating = 5,
                ArtistComment = "He had a great year!! Amazing songs!",
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "limchou@puppy.com"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Pitbull"),
                ArtistRating = 2,
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "limchou@puppy.com"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Gaga"),
                ArtistRating = 5,
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "johnsmith187@puppy.com"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                ArtistRating = 4,
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "tee_frank@hootmail.com"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                ArtistRating = 1,
                ArtistComment = "She went downhill.",
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            AllArtistReviews.Add(new ArtistReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "father.Ingram@aool.com"),
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                ArtistRating = 5,
                ArtistComment = "Taylor is the best artisit ever!!!",
                ArtistReviewStatusType = ArtistReviewStatus.Approved,
            });

            //create a counter and flag to help with debugging
            int intArtistReviewID = 0;
            String strCustomerEmail = "Start@start.com";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Artist Reviews
                foreach (ArtistReview seedArtistReview in AllArtistReviews)
                {
                    //updates the counters to get info on where the problem is
                    intArtistReviewID = seedArtistReview.ArtistReviewID;
                    strCustomerEmail = seedArtistReview.AppUser.Email;

                    //try to find the Artist Review in the database
                    ArtistReview dbArtistReview = db.ArtistReviews.FirstOrDefault(a => a.AppUser.Email == seedArtistReview.AppUser.Email && a.Artist.ArtistName == seedArtistReview.Artist.ArtistName);
           

                    //if the Artist Review isn't in the database, dbArtistReview will be null
                    if (dbArtistReview == null)
                    {
                        //add the Artist Review to the database
                        db.ArtistReviews.Add(seedArtistReview);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbArtistReview.AppUser.Email = seedArtistReview.AppUser.Email;
                        dbArtistReview.Artist = seedArtistReview.Artist;
                        dbArtistReview.ArtistRating = seedArtistReview.ArtistRating;
                        dbArtistReview.ArtistComment = seedArtistReview.ArtistComment;
                        dbArtistReview.ArtistReviewStatusType = seedArtistReview.ArtistReviewStatusType;
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
                msg.Append(strCustomerEmail);
                msg.Append(" Artist (ArtistID = ");
                msg.Append(intArtistReviewID);
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
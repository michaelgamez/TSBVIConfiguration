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
    public static class SeedAlbumReviews
    {
        public static void SeedAllAlbumReviews(AppDbContext db)
        {
            List<AlbumReview> AllAlbumReviews = new List<AlbumReview>();

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "444444.Dave@aool.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                AlbumRating = 1,
                AlbumComment = "Absolute garbage. Not worth the money!",
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "father.Ingram@aool.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                AlbumRating = 3,
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "rwood@voyager.net"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                AlbumRating = 1,
                AlbumComment = "I want to cry",
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "jojoe@puppy.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                AlbumRating = 4,
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "peterstump@hootmail.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                AlbumRating = 3,
                AlbumComment = "It's meh",
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "johnsmith187@puppy.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                AlbumRating = 1,
                AlbumComment = "I would rather go listen to some Nickelback",
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "westj@pioneer.net"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                AlbumRating = 5,
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "lraggrhb854.Taylor@aool.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                AlbumRating = 3,
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });

            AllAlbumReviews.Add(new AlbumReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "father.Ingram@aool.com"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                AlbumRating = 5,
                AlbumComment = "If you're looking for a nice family song, buy this album!",
                AlbumReviewStatusType = AlbumReviewStatus.Approved,
            });




            //create a counter and flag to help with debugging
            int intAlbumReviewID = 0;
            // TODO: Figure out what this do
            String strCustomerEmail = "Start@start.com";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Album Review
                foreach (AlbumReview seedAlbumReview in AllAlbumReviews)
                {
                    //updates the counters to get info on where the problem is
                    intAlbumReviewID = seedAlbumReview.AlbumReviewID;
                    strCustomerEmail = seedAlbumReview.AppUser.Email;

                    //try to find the Album Review in the database
                    AlbumReview dbAlbumReview = db.AlbumReviews.FirstOrDefault(a => a.AppUser.Email == seedAlbumReview.AppUser.Email && a.Album.AlbumTitle == seedAlbumReview.Album.AlbumTitle);

                    //if the Album Review isn't in the database, dbArtist will be null
                    if (dbAlbumReview == null)
                    {
                        //add the Album Review to the database
                        db.AlbumReviews.Add(seedAlbumReview);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbAlbumReview.AppUser.Email = seedAlbumReview.AppUser.Email;
                        dbAlbumReview.Album = seedAlbumReview.Album;
                        dbAlbumReview.AlbumRating = seedAlbumReview.AlbumRating;
                        dbAlbumReview.AlbumComment = seedAlbumReview.AlbumComment;
                        dbAlbumReview.AlbumReviewStatusType = seedAlbumReview.AlbumReviewStatusType;
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
                msg.Append(" Album Review (AlbumReviewID = ");
                msg.Append(intAlbumReviewID);
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

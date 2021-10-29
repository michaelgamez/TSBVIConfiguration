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
    public static class SeedSongReviews
    {
        public static void SeedAllSongReviews(AppDbContext db)
        {
            List<SongReview> AllSongReviews = new List<SongReview>();

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "mb@puppy.com"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Rolling in the Deep"),
                SongRating = 4,
                SongComment = "It speaks to me, as a human.",
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                
                AppUser = db.Users.FirstOrDefault(c => c.Email == "jojoe@puppy.com"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "S&M"),
                SongRating = 3,
                SongComment = "Too edgy for me",
                SongReviewStatusType = SongReviewStatus.Approved,

            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "cbaker@freezing.co.uk"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "When We Stand Together"),
                SongRating = 2,
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "lineback@flush.net"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Prisoner (feat. Dua Lipa)"),
                SongRating = 4,
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "ss34@puppy.com"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Cardigan"),
                SongRating = 2,
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "rwood@voyager.net"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Super Bass"),
                SongRating = 4,
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "tfreeley@puppy.com"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Blow Ya Mind"),
                SongRating = 1,
                SongComment = "Didn't blow my mind",
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "hicks43@puppy.com"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Sicko Mode"),
                SongRating = 3,
                SongReviewStatusType = SongReviewStatus.Approved,
            });

            AllSongReviews.Add(new SongReview
            {
                AppUser = db.Users.FirstOrDefault(c => c.Email == "bradsingram@mall.utexas.edu"),
                Song = db.Songs.FirstOrDefault(c => c.SongTitle == "Preach (feat. PARTYNEXTDOOR)"),
                SongRating = 5,
                SongComment = "Drake is the best rapper of all time. I wish I was friends with Drake",
                SongReviewStatusType = SongReviewStatus.Approved,
            });


            //create a counter and flag to help with debugging
            int intSongReviewID = 0;
            String strCustomerEmail = "Start@start.com";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Song Reviews
                foreach (SongReview seedSongReview in AllSongReviews)
                {
                    //updates the counters to get info on where the problem is
                    intSongReviewID = seedSongReview.SongReviewID;
                    strCustomerEmail = seedSongReview.AppUser.Email;

                    //try to find the Song Review in the database
                    SongReview dbSongReview = db.SongReviews.FirstOrDefault(s => s.AppUser.Email == seedSongReview.AppUser.Email && s.Song.SongTitle == seedSongReview.Song.SongTitle);

                    //if the Song Review isn't in the database, dbArtist will be null
                    if (dbSongReview == null)
                    {
                        //add the Song Review to the database
                        db.SongReviews.Add(seedSongReview);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //you will need it to re-set seeded data with more fields
                        dbSongReview.AppUser.Email = seedSongReview.AppUser.Email;
                        dbSongReview.Song = seedSongReview.Song;
                        dbSongReview.SongRating = seedSongReview.SongRating;
                        dbSongReview.SongComment = seedSongReview.SongComment;
                        dbSongReview.SongReviewStatusType = seedSongReview.SongReviewStatusType;
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
                msg.Append(" Song Review (SongReviewID = ");
                msg.Append(intSongReviewID);
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

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
    public static class SeedSongs
    {
        public static void SeedAllSongs(AppDbContext db)
        {
            List<Song> AllSongs = new List<Song>();

            AllSongs.Add(new Song
            {
                SongTitle = "Rolling in the Deep",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Rumour Has It",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Turning Tables",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Don't You Remember",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Set Fire to the Rain",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "He Won't Go",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Take It All",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I'll Be Waiting",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "One and Only",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Lovesong",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Someone Like You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Found a Boy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Adele"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "21"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Marry the Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Born This Way",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Government Hooker",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Judas",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Americano",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hair",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bloody Mary",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Black Jesus + Amen Fashion",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bad Kids",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Fashion of His Love",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Highway Unicorn (Road to Love)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Heavy Metal Lover",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Electric Chapel",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "The Queen",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "You and I",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "The Edge of Glory",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady GaGa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Born This Way"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Only If For A Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Shake It Out",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "What the Water Gave Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Never Let Me Go",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Breaking Down",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Lover to Lover",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "No Light, No Light",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Seven Devils",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Heartlines",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Spectrum",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "All of This and Heaven Too",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Leave My Body",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Remain Nameless",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Strangeness and Charm",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bedroom Hymns",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "What the Water Gave Me (Demo)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Florence + the Machine"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Ceremonials (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Craving",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hold Back the River",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Let it Go",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "If You Ever Want to Be in Love",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Best Fake Smile",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "When We Were on Fire",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Move Together",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Scars",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Collide",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Get Out While You Can",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Need the Sun to Break",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Incomplete",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "James Bay"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Chaos and the Calm"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Eat Randy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Julian Smith"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Eat Randy - Single"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Misery",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Give a Little More",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Stutter",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Don't Know Nothing",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Never Gonna Leave This Bed",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Can't Lie",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hands All Over",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "How",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Get Back In My Life",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Just a Feeling",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Runaway",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Out of Goodbyes",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Moves Like Jagger",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "The Air That I Breathe",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Maroon 5"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Hands All Over"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Legend",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Energy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "10 Bands",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Know Yourself",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "No Tellin'",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Madonna",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "6 God",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Star67",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Preach (feat. PARTYNEXTDOOR)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Used To (feat. Lil Wayne)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "6 Man",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Now & Forever",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Company (feat. Travi$ Scott)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "You & The 6",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Jungle",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "6PM In New York",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "If You're Reading This It's Too Late"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "S&M",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "What's My Name?",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Cheers",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Fading",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Only Girl (In the World)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "California King Bed",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Man Down",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Raining Men",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Complicated",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Skin",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Love The Way You Lie",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Loud"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Where Them Girls At",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Little Bad Girl",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Turn Me On",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Sweat",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Without You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Nothing Really Matters",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Can Only Imagine",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Crank It Up",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Lunar",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Night of Your Life",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Repeate",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Titanium",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I'm a Machine",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "David Guetta & Usher"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "House"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Nothing But the Beat"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "We Owned the Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Just a Kiss",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Dancin' Away With My Heart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Friday Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "When You Were Mine",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Cold As Stone",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Singing Me Home",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Wanted You More",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "As You Turn Aay",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Love I've Found In You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Somewhere Love Remains",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Heart of the World",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Antebellum"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Own the Night"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I'm the Best",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Roman's Revenge",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Did It On'em",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Right Thru Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Fly",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Save Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Moment 4 Life",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Check It Out",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Blazin'",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Here I Am",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Dear Old Nicki",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Your Love",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Last Chance",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Super Bass",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Blow Ya Mind",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Muny",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Girls Fall Like Dominoes",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nicki Minaj"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Pink Friday (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Honey Bee",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Ready to Roll",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "God Gave Me You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Get Some",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Drink On It",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Good Ole Boys",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I'm Sorry",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Sunny In Seattle",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Over",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hey",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Red River Blue",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Chili",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Addicted",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Blake Shelton"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Red River Blue (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Future Nostalgia",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Don't Start Now",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Cool",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Physical",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Levitating",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Pretty Please",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hallucinate",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Love Again",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Break My Heart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Good In Bed",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Boys Will Be Boys",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Levitating (feat. DaBaby)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Fever",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Future Nostalgia"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "the 1",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "cardigan",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "the last great american dynasty",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "exile (feat. Bon Iver)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "my tears ricochet",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "mirrorball",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "seven",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "august",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "this is me trying",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "illicit affairs",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "invisible string",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "mad woman",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "epiphany",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "betty",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "peace",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "hoax",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Taylor Swift"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Indie"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "folklore"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "If I Die Young",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "All Your Life",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "You Lie",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hip to My Heart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Walk Me Down the Middle",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Independence",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Lasso",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Postcard from Paris",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Quittin' You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Miss You Being Gone",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Double Heart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Band Perry"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Band Perry"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Don’t Worry, Be Happy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Friends",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Thinkin' About Your Body",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Spain",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Freedom is a Voice",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Drive My Car",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Another Night In Tunsia",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Blue Bossa",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Turtle Shoes",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Good Lovin'",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "From Me to You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bang!Zoom",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bobby McFerrin"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Reggae"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Best of Bobby McFerrin"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "The Duck Song",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Bryant Oden"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Children's Music"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "The Duck Song (The Duck and the Lemonade Stand)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Helena Beat",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Pumped Up Kicks",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Call It What You Want",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Don't Stop (Color On the Walls)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Waste",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Would Do Anything for You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Houdini",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Life On the Nickel",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Miss You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Warrant",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Broken Jaw",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Foster the People"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Torches"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "No Church in the Wild",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Lift Off",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Otis",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Gotta Have It",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "New Day",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "That's My Bitch",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Welcome to the Jungle",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Who Gon Stop Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Murder to Excellence",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Made in America",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Why I Love You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "H*a*m",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Primetime",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "The Joy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kanye West & Jay Z"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Watch the Throne (Deluxe Version)"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Love You Like a Love Song",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bang Bang Bang",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Who Says",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "We Own the Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hit the Lights",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Whiplash",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "When the Sun Goes Down",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "My Dilemma",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "That's More Like It",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Outlaw",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Middle of Nowhere",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Dices",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Selena Gomez & the Scene"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "When the Sun Goes Down"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "WTF Do I Know",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Plastic Hearts",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Angels Like You",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Prisoner (feat. Dua Lipa)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Gimme What I Want",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Night Crawling",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Midnight Sky",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "High",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hate Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Bad Karma (feat. Joan Jett)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Never Be Me",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Edge of Midnight",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Heart of Glass",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miley Cyrus"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "Plastic Hearts"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "A Moment Apart",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance "),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Higher Ground (feat. Naomi Wild)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Boy",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 0.69m,
                SongDiscountPrice = 0.69m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Line of Sight (feat. WYNNE)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Late Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 0.69m,
                SongDiscountPrice = 0.69m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Across the Room (feat. Leon Bridges)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Meridian",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Everything at Your Feet",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Just a Memory (feat. Regina Spekter)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Thin Floors and Tall Ceilings",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 0.69m,
                SongDiscountPrice = 0.69m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "La Ciudad",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Odesza"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                Album = db.Albums.FirstOrDefault(c => c.AlbumTitle == "A Moment Apart"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "One Dance",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Hip Hop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Cheap Thrills",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Sia"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Took A Pill In Ibiza",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Mike Posner"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "7 Years",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lukas Graham"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "This Is What You Came For",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Calvin Harris & Rihanna"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "New Rules",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Dua Lipa"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "New York",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "St. Vincent"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Despacito",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Luis Fonsi & Daddy Yankee"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Chanel",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Frank Ocean"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Biscuit Town",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "King Krule"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Sicko Mode",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Travis Scott"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Boo'd Up",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Ella Mai"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "R&B"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Thank U, Next",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Ariana Grande"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.39m,
                SongDiscountPrice = 1.39m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "This Is America",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Childish Gambino"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Shallow",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lady Gaga & Bradley Cooper"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Mo Bamba",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Sheck Wes"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Hip Hop"),
                SongOriginalPrice = 1.49m,
                SongDiscountPrice = 1.49m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Old Town Road",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lil Nas X"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Juice",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Lizzo"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Too Much",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Carly Rae Jepsen"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Blinding Lights",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "The Weeknd"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Give Me Everything (feat. Ne-Yo, Afrojack & Nayer)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Pitbull"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Focused (feat. Kid Cudi)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Wale"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Hip Hop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Mr. Saxobeat (Radio Edit)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Alexandra Stan"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "When We Stand Together",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nickelback"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rock"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "You the Boss (feat. Nicki Minaj)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Rick Ross"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Round of Applause (feat. Drake)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Waka Flocka Flame"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Hip Hop"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Domino",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Jessie J"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Hello",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Martin Solveig & Dragonette"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Dance"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Barefoot Blue Jean Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Jake Owen"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Marvins Room",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Drake"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Got 2 Luv U (feat. Alexis Jordan)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Sean Paul"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Baggage Claim",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Miranda Lambert"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Country"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "I Like It Like That (feat. New Boyz)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Hot Chelle Rae"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Good Good Night",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Roscoe Dash"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Hip Hop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Face to the Floor",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Chevelle"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rock"),
                SongOriginalPrice = 0.89m,
                SongDiscountPrice = 0.89m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Steal My Girl",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "One Direction"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.29m,
                SongDiscountPrice = 1.29m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Jealous",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Nick Jonas"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Uptown Funk (ft. Bruno Mars)",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Mark Ronson"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Pop"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "Take Me to Church",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Hozier"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Alternative"),
                SongOriginalPrice = 0.99m,
                SongDiscountPrice = 0.99m,
            });

            AllSongs.Add(new Song
            {
                SongTitle = "These Walls",
                Artist = db.Artists.FirstOrDefault(c => c.ArtistName == "Kendrick Lamar"),
                Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Rap"),
                SongOriginalPrice = 1.19m,
                SongDiscountPrice = 1.19m,
            });




            Int32 intSongID = 0;
            String strSongTitle = "Start";

            //loop through the list to add or update the job posting
            try
            {
                foreach (Song seedSong in AllSongs)
                {
                    //update the counters
                    intSongID = seedSong.SongID;
                    strSongTitle = seedSong.SongTitle;

                    //see if the show is already in the database using the UniqueIdentifier
                    Song dbSong = db.Songs.FirstOrDefault(c => c.SongID == seedSong.SongID);

                    if (dbSong == null)
                    {
                        //add the Category to the database
                        db.Songs.Add(seedSong);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for category because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbSong.SongTitle = seedSong.SongTitle;
                        dbSong.Artist = seedSong.Artist;
                        dbSong.Genre = seedSong.Genre;
                        dbSong.SongOriginalPrice = seedSong.SongOriginalPrice;
                        dbSong.Album = seedSong.Album;
                        
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the song with the title: ");
                msg.Append(strSongTitle);
                msg.Append(" (SongID: ");
                msg.Append(intSongID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }



        }
    }
}

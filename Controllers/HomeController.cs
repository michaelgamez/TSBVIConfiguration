using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using spr21team24finalproject.DAL;
using spr21team24finalproject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace spr21team24finalproject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private AppDbContext _context;

        //instantiate an object of AppDbContext and makin it parameter for homercontroller
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }


        [Authorize(Roles = "Manager")]
        // GET: SongReviews/Create
        public IActionResult FeaturedSongCreate()
        {
            return View();
        }
     
        // GET: SongReviews/Create
   
        // POST: SongReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FeaturedSongAlbumDisplay(FeaturedViewModel fvm)
        {
            if (ModelState.IsValid == false)
            {
                return View(fvm);
            }
            //Find the logged in user using the UserManager

            return RedirectToAction("Index", "Home");
        }

       


        //Creates action method for index with searchstring parameter
        public IActionResult Index(string SearchString)
        {
            //creates base for query  
            var query = from s in _context.Songs
                        select s;

            //adds where to query and define where to look for the searchstring
            if (SearchString != null)
            {
                if (SearchString != null)
                {
                    query = query.Where(s => s.SongTitle.Contains(SearchString));
                }


                //create search criteria if album title has been filled out
                if (SearchString != null)
                {
                    query = query.Where(s => s.Album.AlbumTitle.Contains(SearchString));
                }


                //create search criteria if artist name has been filled out
                if (SearchString != null)
                {
                    query = query.Where(s => s.Artist.ArtistName.Contains(SearchString));
                }



                //query = query.Where(s => s.SongTitle.Contains(SearchString) ||
                //                        s.Album.AlbumTitle.Contains(SearchString) ||
                //                        s.Artist.ArtistName.Contains(SearchString));

                //query = query.Where(s => s.SongTitle.Contains(SearchString) || s.Artist.ArtistName.Contains(SearchString) || s.Album.AlbumTitle.Contains(SearchString));
            }

            List<Song> SelectedSongs = query.Include(s => s.Artist)
                                            .Include(s => s.Album)
                                            .ToList();

            //Populate the view bag with a count of all songs
            ViewBag.AllSongs = _context.Songs.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedSongs = SelectedSongs.Count;

            return View(SelectedSongs.OrderBy(s => s.SongTitle));


            //List<Song> SelectedSongs = query.Include(s => s.Artist)
            //                                .Include(s => s.Album)
            //                                .ToList();

            ////Populate the view bag with a count of all shows
            //ViewBag.AllSongs = _context.Songs.Count();
            ////Populate the view bag with a count of selected shows
            //ViewBag.SelectedSongs = SelectedSongs.Count;

            ////return the view and order by title alphabetically
            //return View(SelectedSongs.OrderBy(s => s.SongTitle));
        }

        public IActionResult Details(int? id)//id is the song id you want to see
        {
            if (id == null) //SongID not specified
            {    //user did not specify a ShowID – take them to the error view
                return View("Error", new String[] { "SongID not specified - which song do you want to view?" });
            }

            //look up the show in the database based on the id; be sure to include the category
            Song song = _context.Songs.Include(s => s.Artist)
                                  .Include(s => s.Album)
                                  .ThenInclude(s=> s.Genre)
                                  .FirstOrDefault(s => s.SongID == id);

            if (song == null) //No song with this id exists in the database
            {
                //there is not a show with this id in the database – show the user an error view
                return View("Error", new String[] { "Song not found in database" });
            }

            //if code gets this far, all is well – display the details
            return View(song);

        }

        //Creates action method for Detailed Search
        public IActionResult SongDetailedSearch()
        {
            ViewBag.AllGenres = GetAllGenres();
            return View();
        }

        //Creates action method for Detailed Search
        public IActionResult AlbumDetailedSearch()
        {

            ViewBag.AllGenres = GetAllGenres();
            return View();
        }

        //Creates action method for Detailed Search
        public IActionResult ArtistDetailedSearch()
        {
            ViewBag.AllGenres = GetAllGenres();
            return View();
        }

        private SelectList GetAllGenres()
        {
            //Get the list of genres from the database
            List<Genre> genreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all categories
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
            genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            //return the SelectList
            return genreSelectList;
        }


        //Create action method for DisplaySongSearchResults with svm parameter
        public IActionResult DisplaySongSearchResults(SearchViewModel svm)
        {
            var query = from s in _context.Songs
                        select s;

            //create search criteria if Song title has been filled out
            if (svm.SearchSongTitle != null)
            {
                query = query.Where(s => s.SongTitle.Contains(svm.SearchSongTitle));
            }


            //create search criteria if album title has been filled out
            if (svm.SearchAlbumTitle != null)
            {
                query = query.Where(s => s.Album.AlbumTitle.Contains(svm.SearchAlbumTitle));
            }


            //create search criteria if artist name has been filled out
            if (svm.SearchArtistName != null)
            {
                query = query.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
            }

            
            

            //create search criteria if category has been selected
            if (svm.SearchGenre != 0)
            {
                query = query.Where(s => s.Genre.GenreID == svm.SearchGenre);
            }


            List<Song> SelectedSongs = query.Include(s => s.Genre)
                                            .Include(s => s.SongReviews)
                                            .Include(s => s.Artist)
                                            .Include(s => s.Album)
                                            .ToList();

            //create search criteria if Rating has been filled out
            //TODO: How do you search for the rating type 
            if (svm.SearchAvgRating != null)
            {
                //Nested if statement for the before Rating search type
                if (svm.SearchRatingType == SearchRatingType.lessThan)
                {

                    SelectedSongs = SelectedSongs.Where(s => s.SongAvgRating <= svm.SearchAvgRating).ToList();
                    //query = query.Where(s => s.SongAvgRating <= svm.SearchAvgRating);
                }
                else //if not before then after
                {
                    SelectedSongs = SelectedSongs.Where(s => s.SongAvgRating >= svm.SearchAvgRating).ToList();

                    // query = query.Where(s => s.SongAvgRating >= svm.SearchAvgRating);
                }
            }

            //Populate the view bag with a count of all songs
            ViewBag.AllSongs = _context.Songs.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedSongs = SelectedSongs.Count;

            return View("SongSearchResults", SelectedSongs.OrderBy(s => s.SongTitle));
        }


        //Create action method for DisplayAlbumSearchResults with svm parameter
        public IActionResult DisplayAlbumSearchResults(SearchViewModel svm, string sortOrder)
        {
            var query = from s in _context.Albums
                        select s;

            //create search criteria if album title has been filled out
            if (svm.SearchAlbumTitle != null)
            {
                query = query.Where(s => s.AlbumTitle.Contains(svm.SearchAlbumTitle));
            }


            //create search criteria if artist name has been filled out
            if (svm.SearchArtistName != null)
            {
                query = query.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
            }

            //create search criteria if Rating has been filled out
            //TODO: How do you search for the rating type 
            

            //create search criteria if category has been selected
            if (svm.SearchGenre != 0)
            {
                query = query.Where(s => s.Genre.GenreID == svm.SearchGenre);
            }


            List<Album> SelectedAlbums = query.Include(s => s.Artist)
                                            .Include(s => s.Songs)
                                            .Include(s => s.AlbumReviews)
                                            .Include(s => s.Genre)
                                            .ToList();

            if (svm.SearchAvgRating != null)
            {
                //Nested if statement for the before Rating search type
                if (svm.SearchRatingType == SearchRatingType.lessThan)
                {
                    SelectedAlbums = SelectedAlbums.Where(s => s.AlbumAvgRating <= svm.SearchAvgRating).ToList();

                    //query = query.Where(s => s.AlbumAvgRating <= svm.SearchAvgRating);
                }
                else //if not before then after
                {
                    SelectedAlbums = SelectedAlbums.Where(s => s.AlbumAvgRating >= svm.SearchAvgRating).ToList();

                    //query = query.Where(s => s.AlbumAvgRating >= svm.SearchAvgRating);
                }
            }

            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "AlbumTitle" : "";
            //ViewBag.NameSortParm = sortOrder == "ArtistName" ? "AlbumAvgRating" : "Artist";

            //var albums = from a in SelectedAlbums
            //             select a;

            //switch(SelectedAlbums)
            //{
            //    case "AlbumTitle":
            //        albums = albums.OrderByDescending(s => s.AlbumTitle);
            //        break;
            //    case "ArtistName":
            //        albums = albums.OrderByDescending(s => s.Artist.ArtistName);
            //        break;
            //    case "AlbumAvgRating":
            //        albums = albums.OrderByDescending(s => s.AlbumAvgRating);
            //        break;
            //    default:
            //        albums = albums.OrderBy(s => s.AlbumTitle);
            //        break;

            //}


            ViewBag.AllAlbums = _context.Albums.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedAlbums = SelectedAlbums.Count;

            return View("AlbumSearchResults", SelectedAlbums); //OrderBy(s => s.AlbumTitle)

        }
        //Create action method for DisplayArtistSearchResults with svm parameter
        public IActionResult DisplayArtistSearchResults(SearchViewModel svm)
        {
            var query = from s in _context.Artists
                        select s;


            //create search criteria if artist name has been filled out
            if (svm.SearchArtistName != null)
            {
                query = query.Where(s => s.ArtistName.Contains(svm.SearchArtistName));
            }


            //create search criteria if category has been selected
            if (svm.SearchGenre != 0)
            {
                query = query.Where(a => a.Songs.Any(s => s.Genre.GenreID == svm.SearchGenre) || a.Albums.Any(al => al.Genre.GenreID == svm.SearchGenre));
            }

            List<Artist> SelectedArtists = query.Include(s => s.Albums)
                                        .Include(s => s.Songs)
                                        .ThenInclude(s => s.Genre)
                                        .Include(s => s.ArtistReviews)
                                        .ToList();

            if (svm.SearchAvgRating != null)
            {
                //Nested if statement for the before Rating search type
                if (svm.SearchRatingType == SearchRatingType.lessThan)
                {
                    SelectedArtists = SelectedArtists.Where(s => s.ArtistAvgRating <= svm.SearchAvgRating).ToList();
                }
                else //if not before then after
                {
                    SelectedArtists = SelectedArtists.Where(s => s.ArtistAvgRating >= svm.SearchAvgRating).ToList();
                }
            }

            ViewBag.AllArtists = _context.Artists.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedArtists = SelectedArtists.Count;

            return View("ArtistSearchResults", SelectedArtists.OrderBy(s => s.ArtistName));


        }


        



        /*
        //Create action method for DisplaySearchResults with svm parameter
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            var querysongs = from s in _context.Songs
                        select s;

            var queryalbums = from s in _context.Albums
                             select s;

            var queryartists = from s in _context.Artists
                              select s;


            //songs--------------------------------------------------------------------------------------

            //create search criteria if Song title has been filled out
            if (svm.SearchSongTitle != null)
            {
                querysongs = querysongs.Where(s => s.SongTitle.Contains(svm.SearchSongTitle));

                if (svm.SearchAlbumTitle != null)
                {
                    querysongs = querysongs.Where(s => s.Album.AlbumTitle.Contains(svm.SearchAlbumTitle));
                }

                if (svm.SearchArtistName != null)
                {
                    querysongs = querysongs.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
                }

                //Nested if statement for the before Rating search type
                if (svm.SearchAvgRating != null)
                {

                    if (svm.SearchRatingType == SearchRatingType.lessThan)
                    {
                        querysongs = querysongs.Where(s => s.SongAvgRating <= svm.SearchAvgRating);
                    }
                    else //if not before then after
                    {
                        querysongs = querysongs.Where(s => s.SongAvgRating >= svm.SearchAvgRating);
                    }
                }

                //create search criteria if category has been selected
                if (svm.SearchGenre != 0)
                {
                    querysongs = querysongs.Where(s => s.Genre.GenreID == svm.SearchGenre);
                }
            }
            

            List<Song> SelectedSongs = querysongs.Include(s => s.Artist)
                                            .Include(s => s.Album)
                                            .ThenInclude(s => s.Genre)
                                            .ToList();
            
            ViewBag.AllSongs = _context.Songs.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedSongs = SelectedSongs.Count;



            //ALBUM----------------------------------------------------------------------------------

            //create search criteria if album title has been filled out
            if (svm.SearchAlbumTitle != null)
            {
                queryalbums = queryalbums.Where(s => s.AlbumTitle.Contains(svm.SearchAlbumTitle));
                if (svm.SearchArtistName != null)
                {
                    queryalbums = queryalbums.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
                }
                if (svm.SearchAvgRating != null)
                {

                    if (svm.SearchRatingType == SearchRatingType.lessThan)
                    {
                        queryalbums = queryalbums.Where(s => s.AlbumAvgRating <= svm.SearchAvgRating);
                    }
                    else //if not before then after
                    {
                        queryalbums = queryalbums.Where(s => s.AlbumAvgRating >= svm.SearchAvgRating);
                    }
                }

                //create search criteria if category has been selected
                if (svm.SearchGenre != 0)
                {
                    queryalbums = queryalbums.Where(s => s.Genre.GenreID == svm.SearchGenre);
                }
            }
            


            List<Album> SelectedAlbums = queryalbums.Include(s => s.Artist)
                                            .Include(s => s.Songs)
                                            .ThenInclude(s => s.Genre)
                                            .ToList();

            ViewBag.AllAlbums = _context.Albums.Count();
            //Populate the view bag with a count of selected songs
            ViewBag.SelectedAlbums = SelectedAlbums.Count;



            //ARTISTS----------------------------------------------------------------------------------

            //create search criteria if artist name has been filled out
            if (svm.SearchArtistName != null)
            {
                queryartists = queryartists.Where(s => s.ArtistName.Contains(svm.SearchArtistName));

                if (svm.SearchAvgRating != null)
                {

                    if (svm.SearchRatingType == SearchRatingType.lessThan)
                    {
                        queryartists = queryartists.Where(s => s.ArtistAvgRating <= svm.SearchAvgRating);
                    }
                    else //if not before then after
                    {
                        queryartists = queryartists.Where(s => s.ArtistAvgRating >= svm.SearchAvgRating);
                    }
                }

                //create search criteria if category has been selected
                if (svm.SearchGenre != 0)
                {
                    queryartists = queryartists.Where(a => a.Songs.Any(s => s.Genre.GenreID == svm.SearchGenre) || a.Albums.Any(al => al.Genre.GenreID == svm.SearchGenre));
                }
            }
           


            List<Artist> SelectedArtists = queryartists.Include(s => s.Songs)
                                            .Include(s => s.Albums)
                                            .ThenInclude(s => s.Genre)
                                            .ToList();

            //GENRES----------------------------------------------------------------------------------
            if (svm.SearchGenre != 0)
            {
                querysongs = querysongs.Where(s => s.Genre.GenreID == svm.SearchGenre);

                queryalbums = queryalbums.Where(s => s.Genre.GenreID == svm.SearchGenre);

                queryartists = queryartists.Where(a => a.Songs.Any(s => s.Genre.GenreID == svm.SearchGenre) || a.Albums.Any(al => al.Genre.GenreID == svm.SearchGenre));

                if(svm.SearchAvgRating != null)
                {
                    if (svm.SearchRatingType == SearchRatingType.lessThan)
                    {
                        querysongs = querysongs.Where(s => s.SongAvgRating <= svm.SearchAvgRating);

                        queryalbums = queryalbums.Where(s => s.AlbumAvgRating <= svm.SearchAvgRating);

                        queryartists = queryartists.Where(s => s.ArtistAvgRating <= svm.SearchAvgRating);

                    }
                    else //if not before then after
                    {
                        querysongs = querysongs.Where(s => s.SongAvgRating >= svm.SearchAvgRating);

                        queryalbums = queryalbums.Where(s => s.AlbumAvgRating >= svm.SearchAvgRating);

                        queryartists = queryartists.Where(s => s.ArtistAvgRating >= svm.SearchAvgRating);
                    }
                }
            }

            //RATINGS----------------------------------------------------------------------------------
           
            if (svm.SearchAvgRating != null)
            {
                if (svm.SearchRatingType == SearchRatingType.lessThan)
                {
                    querysongs = querysongs.Where(s => s.SongAvgRating <= svm.SearchAvgRating);

                    queryalbums = queryalbums.Where(s => s.AlbumAvgRating <= svm.SearchAvgRating);

                    queryartists = queryartists.Where(s => s.ArtistAvgRating <= svm.SearchAvgRating);

                }
                else //if not before then after
                {
                    querysongs = querysongs.Where(s => s.SongAvgRating >= svm.SearchAvgRating);

                    queryalbums = queryalbums.Where(s => s.AlbumAvgRating >= svm.SearchAvgRating);

                    queryartists = queryartists.Where(s => s.ArtistAvgRating >= svm.SearchAvgRating);
                }

                if (svm.SearchGenre != 0)
                {
                    querysongs = querysongs.Where(s => s.Genre.GenreID == svm.SearchGenre);

                    queryalbums = queryalbums.Where(s => s.Genre.GenreID == svm.SearchGenre);

                    queryartists = queryartists.Where(a => a.Songs.Any(s => s.Genre.GenreID == svm.SearchGenre) || a.Albums.Any(al => al.Genre.GenreID == svm.SearchGenre));
                }
            }


            /*
            //create search criteria if Rating has been filled out
            //TODO: How do you search for the rating type 
            if (svm.SearchAvgRating != null)
            {
                if (svm.SearchSongTitle != null && svm.SearchAlbumTitle == null && svm.SearchArtistName)
                    //Nested if statement for the before Rating search type
                    if (svm.SearchRatingType == SearchRatingType.lessThan)
                    {
                        querysongs = query.Where(s => s.SongAvgRating <= svm.SearchAvgRating);
                    }
                    else //if not before then after
                    {
                        query = query.Where(s => s.SongAvgRating >= svm.SearchAvgRating);
                    }
            }
            if (svm.SearchAvgRating != null &)
           
            //queryall = querysongs + queryalbums + queryartists;

            //Everything = SelectedSongs.Concat(SelectedAlbums).Concat(SelectedArtists).ToList();
            //return View("DisplaySearchResults", SelectedSongs.OrderBy(s => s.SongTitle));
            return View("DisplaySearchResults", (SelectedSongs.OrderBy(s => s.SongTitle), SelectedAlbums.OrderBy(s => s.AlbumTitle), SelectedArtists.OrderBy(s => s.ArtistName)));
        }

    */






        /*
       //Create action method for DisplaySearchResults with svm parameter
       public IActionResult DisplaySearchResults(SearchViewModel svm)
           {
       var query = from s in _context.Songs
                   select s;

       //create search criteria if Song title has been filled out
       if (svm.SearchSongTitle != null)
       {
           query = query.Where(s => s.SongTitle.Contains(svm.SearchSongTitle));
       }


       //create search criteria if album title has been filled out
       if (svm.SearchAlbumTitle != null)
       {
           query = query.Where(s => s.Album.AlbumTitle.Contains(svm.SearchAlbumTitle));
       }


       //create search criteria if artist name has been filled out
       if (svm.SearchArtistName != null)
       {
           query = query.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
       }

       //create search criteria if Rating has been filled out
       //TODO: How do you search for the rating type 
       if (svm.SearchAvgRating != null)
       {
           //Nested if statement for the before Rating search type
           if (svm.SearchRatingType == SearchRatingType.lessThan)
           {
               query = query.Where(s => s.SongAvgRating <= svm.SearchAvgRating);
           }
           else //if not before then after
           {
               query = query.Where(s => s.SongAvgRating >= svm.SearchAvgRating);
           }
       }

       //create search criteria if category has been selected
       if (svm.SearchGenre != 0)
       {
           query = query.Where(s => s.Genre.GenreID == svm.SearchGenre);
       }


       //create search criteria if Description has been filled out
       if (svm.Description != null)
       {
           query = query.Where(s => s.Description.Contains(svm.Description));
       }


       List<Song> SelectedSongs = query.Include(s => s.Artist)
                                       .Include(s => s.Album)
                                       .ThenInclude(s => s.Genre)
                                       .ToList();

       //Populate the view bag with a count of all songs
       ViewBag.AllSongs = _context.Songs.Count();
       //Populate the view bag with a count of selected songs
       ViewBag.SelectedSongs = SelectedSongs.Count;

       return View("DisplaySearchResults", SelectedSongs.OrderBy(s => s.SongTitle));

       }*/
    }
}
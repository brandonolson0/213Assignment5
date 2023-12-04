using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment5.Data;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class SongsController : Controller
    {
        private readonly Assignment5Context _context;

        public SongsController(Assignment5Context context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index(string songGenre, string songArtist)
        {
            if (_context.Song == null)
            {
                return Problem("Entity set 'Assignment5Context.Song'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Song
                                            orderby m.Genre
                                            select m.Genre;

            var songs = from s in _context.Song
                         select s;

            if (!string.IsNullOrEmpty(songArtist))
            {
                songs = songs.Where(s => s.Artist!.Contains(songArtist));
            }

            if (!string.IsNullOrEmpty(songGenre))
            {
                songs = songs.Where(x => x.Genre == songGenre);
            }

            // Use LINQ to get list of artists.
            IQueryable<string> artistQuery = from m in songs
                                             orderby m.Artist
                                             select m.Artist;

            var songGenreVM = new SongGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Artists = new SelectList(await artistQuery.Distinct().ToListAsync()),
                Songs = await songs.ToListAsync()
            };

            return View(songGenreVM);
        }

    }
}

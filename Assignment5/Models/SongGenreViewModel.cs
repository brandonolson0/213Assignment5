﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment5.Models
{
    public class SongGenreViewModel
    {
        public List<Song>? Songs { get; set; }
        public SelectList? Genres { get; set; }
        public SelectList? Artists { get; set; }
        public string? SongGenre { get; set; }
        public string? SongArtist { get; set; }

    }
}

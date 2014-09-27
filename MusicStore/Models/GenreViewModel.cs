using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace MusicStore.Models
{
    public class GenreViewModel
    {
        public List<Genre> AllGenres { get; set; }
        public Genre GetSelectedGenre { get; set; }
    }
}
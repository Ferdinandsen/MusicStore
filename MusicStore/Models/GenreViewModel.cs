using System.Collections.Generic;
using DAL;

namespace MusicStore.Models
{
    public class GenreViewModel
    {
        public List<Genre> AllGenres { get; set; }
        public Genre GetSelectedGenre { get; set; }
    }
}
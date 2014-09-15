using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace MusicStore.Models
{
    public class CreateAlbumViewModel
    {
        public List<Artist> GetAllArtists { get; set; }
        public List<Genre> GetAllGenres { get; set; }

    }
}
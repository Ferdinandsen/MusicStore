using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace MusicStore.Models
{
    public class AlbumViewModels
    {
        public List<Album> AllAlbums { get; set; }
        public Album GetSelectedAlbum { get; set; }
        public List<Artist> AllArtists { get; set; }
        public List<Genre> AllGenres { get; set; }
    }
}
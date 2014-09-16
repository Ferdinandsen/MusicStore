using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class ArtistViewModel
    {
        public List<Artist> AllArtists { get; set; }
        public Artist GetSelectedArtist { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Genre { get; set; }
        public int Artist { get; set; }
        public string AlbumArtUrl { get; set; }
        public string SongSampleUrl { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
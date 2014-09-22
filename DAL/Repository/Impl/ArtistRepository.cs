using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Impl
{
    internal class ArtistRepository : IArtistRepo
    {
        public List<Artist> GetAllArtist()
        {
            using (var db = new DBConnection())
            {
                return db.Artists.ToList();
            }
        }

        public void CreateArtist(Artist artist)
        {
            using (var db = new DBConnection())
            {
                db.Artists.Add(artist);
                db.SaveChanges();
            }
        }
    }
}

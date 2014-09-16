using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace DAL.Repository.Impl
{
    internal class ArtistRepository : IArtistRepo
    {
        public List<Artist> GetAllArtist()
        {
            using (DBConnection db = new DBConnection())
            {
                return db.Artists.ToList();
            }
        }

        public void createArtist(Artist artist)
        {
            using (var db = new DBConnection())
            {
                db.Artists.Add(artist);
                db.SaveChanges();
            }
        }
    }
}

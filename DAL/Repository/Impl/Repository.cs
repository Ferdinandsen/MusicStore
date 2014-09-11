using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Impl
{
    internal class Repository : IRepository
    {
        public List<Album> GetAllAlbums()
        {
            using (DBConnection db = new DBConnection())
            {
                return db.Albums.ToList();
            }
        }

        public List<Artist> GetArtistByAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public void CreateAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public void Details(Album album)
    {
            throw new NotImplementedException();
        }
    }
}

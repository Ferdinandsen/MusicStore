using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace DAL.Repository.Impl
{
    internal class AlbumRepository : IAlbumRepository
    {
        public List<Album> GetAllAlbums()
        {
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    return db.Albums.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("fejl" + e.Message);
                throw;
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

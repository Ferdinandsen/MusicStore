using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Impl
{
    public class Repository : IRepository
    {
        public List<Album> GetAllAlbums()
        {
            try
            {
                using (var db = new DBConnection())
                {
                    Console.WriteLine("nu er vi i repository");
                    return db.Albums.ToList();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fuck");
            }
            return null;

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

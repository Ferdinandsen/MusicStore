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
                    return db.Albums.Include("Genre").Include("Artist").ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("fejl" + e.Message);
                throw;
            }
        }

        public void CreateAlbum(Album album)
        {
            using (var db = new DBConnection())
            {
                db.Albums.Add(album);
                db.SaveChanges();
            }
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album album)
        {
            throw new NotImplementedException();
        }


        public Album GetAlbumById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

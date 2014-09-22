using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Impl
{
    internal class AlbumRepository : IAlbumRepository
    {
        public void CreateAlbum(Album album)
        {
            using (var db = new DBConnection())
            {
                db.Albums.Add(album);
                db.SaveChanges();
            }
        }

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
        public Album GetAlbumById(int? id)
        {
            using (var db = new DBConnection())
            {
                return db.Albums.Include("Genre").Include("Artist").Where(x => x.id == id).Single();
            }
        }

        public void Update(Album oldAlbum, Album newAlbum)
        {
            using (var db = new DBConnection())
            {
                db.Albums.Remove(oldAlbum);
                db.Albums.Add(newAlbum);
                db.SaveChanges();
            }
        }

        public void Delete(Album album)
        {
            throw new NotImplementedException();
        }
    }
}

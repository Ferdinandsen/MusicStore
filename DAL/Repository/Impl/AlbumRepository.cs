using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                using (var db = new DBConnection())
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
            try
            {
                using (var db = new DBConnection())
                {
                    return db.Albums.Include("Genre").Include("Artist").Single(x => x.id == id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in retrieving the specific artist" + e.Message);
                throw;
            }
        }

        public void Update(Album album)
        {
            using (var db = new DBConnection())
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DBConnection())
            {
                db.Albums.Remove(db.Albums.FirstOrDefault(x => x.id == id));
                db.SaveChanges();
            }
        }
    }
}

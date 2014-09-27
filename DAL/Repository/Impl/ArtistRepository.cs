using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository.Impl
{
    internal class ArtistRepository : IArtistRepo
    {
        public List<Artist> GetAllArtist()
        {
            try
            {
                using (var db = new DBConnection())
                {
                    return db.Artists.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in retrieving Artist" + e.Message);
                throw;
            }
        }

        public void CreateArtist(Artist artist)
        {
            try
            {
                using (var db = new DBConnection())
                {
                    db.Artists.Add(artist);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in creating the Artist" + e.Message);
                throw;
            }
        }

        public Artist GetArtistById(int? id)
        {
            using (var db = new DBConnection())
            {
                return db.Artists.FirstOrDefault(x => x.id == id);
            }
        }

        public void UpdateArtist(Artist artist)
        {
            using (var db = new DBConnection())
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteArtist(int id)
        {
            using (var db = new DBConnection())
            {
                db.Artists.Remove(db.Artists.FirstOrDefault(x => x.id == id));
                db.SaveChanges();
            }
        }
    }
}

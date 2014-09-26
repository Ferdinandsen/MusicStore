using System;
using System.Collections.Generic;
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

        public void UpdateArtist(Artist oldArtist, Artist newArtist)
        {
            using (var db = new DBConnection())
            {
                db.Artists.Remove(oldArtist);
                db.Artists.Add(newArtist);
                db.SaveChanges();
            }
        }

        public void DeleteArtist(Artist artist)
        {
            using (var db = new DBConnection())
            {
                db.Artists.Remove(artist);
                db.SaveChanges();
            }

        }
    }
}

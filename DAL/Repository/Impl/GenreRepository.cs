using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;

namespace DAL.Repository.Impl
{
    internal class GenreRepository : IGenreRepo
    {
        public List<Genre> GetAllGenres()
        {
            using (var db = new DBConnection())
            {
                return db.Genres.ToList();
            }
        }
        public void CreateGenre(Genre genre)
        {
            using (var db = new DBConnection())
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }
        }

        public Genre GetGenreById(int? id)
        {
            using (var db = new DBConnection())
            {
                return db.Genres.FirstOrDefault(x => x.id == id);
            }
        }
        public void UpdateGenre(Genre genre)
        {
           using (var db = new DBConnection())
            {
                db.Entry(genre).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteGenre(int id)
        {
            using (var db = new DBConnection())
            {
                db.Genres.Remove(db.Genres.FirstOrDefault(x=>x.id == id));
                db.SaveChanges();
            }
        }
    }
}

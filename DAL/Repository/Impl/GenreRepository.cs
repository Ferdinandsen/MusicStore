using System.Collections.Generic;
using System.Linq;

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
        
        public Genre GetGenreById(int id)
        {
            using (var db = new DBConnection())
            {
                return db.Genres.FirstOrDefault(x => x.id == id);
            }
            
        }
    }
}

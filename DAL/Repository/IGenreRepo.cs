using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IGenreRepo
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int? id);
        void CreateGenre(Genre genre);
        void UpdateGenre(Genre genre);
    }
}

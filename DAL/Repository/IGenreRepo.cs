using System.Collections.Generic;

namespace DAL.Repository
{
   public interface IGenreRepo
    {
        List<Genre> GetAllGenres();
       void CreateGenre(Genre genre);
    }
}

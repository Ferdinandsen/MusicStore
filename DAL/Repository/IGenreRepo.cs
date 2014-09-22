using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.GenreRepo
{
    public interface IGenreRepo
    {
        List<Genre> GetAllGenres();
        void CreateGenre(Genre genre);
    }
}

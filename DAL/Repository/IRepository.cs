using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository
    {
        List<Album> GetAllAlbums();
        List<Artist> GetArtistByAlbum(Album album);

        void CreateAlbum(Album album);

        void Update(Album album);

        void Delete(Album album);

        void Details(Album album);
    }
}

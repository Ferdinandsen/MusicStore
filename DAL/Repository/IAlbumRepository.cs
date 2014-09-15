using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IAlbumRepository
    {
        List<Album> GetAllAlbums();

        Album GetAlbumById(int id);

        void CreateAlbum(Album album);

        void Update(Album album);

        void Delete(Album album);
              
    }
}

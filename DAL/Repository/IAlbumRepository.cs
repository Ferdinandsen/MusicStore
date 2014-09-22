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

        void CreateAlbum(Album album);

        void Update(Album oldAlbum, Album newAlbum);

        void Delete(Album album);

        Album GetAlbumById(int? id);
    }
}

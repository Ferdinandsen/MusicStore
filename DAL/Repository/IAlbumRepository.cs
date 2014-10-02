using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IAlbumRepository
    {
        List<Album> GetAllAlbums();

        void CreateAlbum(Album album);

        void Update(Album album);

        void Delete(int id);

        Album GetAlbumById(int? id);
    }
}

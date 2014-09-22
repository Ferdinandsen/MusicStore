using System.Collections.Generic;

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

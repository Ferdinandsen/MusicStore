using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IArtistRepo
    {
        List<Artist> GetAllArtist();
        Artist GetArtistById(int? id);
        void CreateArtist(Artist artist);

        void UpdateArtist(Artist oldArtist, Artist newArtist);

        void DeleteArtist(Artist artist);
    }
}

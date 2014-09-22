using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IArtistRepo
    {
             List<Artist> GetAllArtist();
             void CreateArtist(Artist artist);
    }
}

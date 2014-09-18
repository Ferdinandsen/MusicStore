using DAL.Repository;
using DAL.Repository.GenreRepo;
using DAL.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayerfacade
    {
        IAlbumRepository alRep;
        IArtistRepo arRep;
        IGenreRepo gRep;

        public IAlbumRepository GetAlbumRep()
        {
            return alRep != null ? alRep : alRep = new AlbumRepository();
        }
        public IArtistRepo GetArtistRep()
        {
            return arRep != null ? arRep : arRep = new ArtistRepository();
        }

        public IGenreRepo GetGenreRep()
        {
            return gRep != null ? gRep : gRep = new GenreRepository();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Repository;
using DAL.Repository.Impl;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        DataAccessLayerfacade facade;
        AlbumViewModels model;

        // GET: Album
        public ActionResult Index(int? id)
        {
            facade = new DataAccessLayerfacade();
            model = new AlbumViewModels();

            if (facade.GetAlbumRep().GetAllAlbums().Count == 0)
            {
                model.AllAlbums = facade.GetAlbumRep().GetAllAlbums();
            }
            else
            {
                model.AllAlbums = facade.GetAlbumRep().GetAllAlbums();
                model.GetSelectedAlbum = id != null ? model.AllAlbums.FirstOrDefault(a => a.id == id) : model.AllAlbums.FirstOrDefault();
            }
            return View(model);
        }

        public ActionResult CreateAlbum()
        {
            facade = new DataAccessLayerfacade();
            AlbumViewModels model = new AlbumViewModels();
            model.AllArtists = facade.GetArtistRep().GetAllArtist();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddAlbum(AlbumModel model)
        {
            facade = new DataAccessLayerfacade();
            facade.GetAlbumRep().CreateAlbum(new Album { title = model.Title, artistId = model.Artist, price = model.Price, genreId = model.Genre, albumArtURL = model.AlbumArtUrl, songSampleURL = model.SongSampleUrl, releaseDate = model.ReleaseDate });
            return RedirectToAction("Index");
        }

        public ActionResult UpdateAlbum(int? id)
        {
            facade = new DataAccessLayerfacade();
            model = new AlbumViewModels();
            model.GetSelectedAlbum = facade.GetAlbumRep().GetAlbumById(id);
            return View(model);
        }
    }
}
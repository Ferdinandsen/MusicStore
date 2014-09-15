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
        Albumfacade facade;

        // GET: Album
        public ActionResult Index(int? id)
        {
            facade = new Albumfacade();
            AlbumViewModels model = new AlbumViewModels();
            model.AllAlbums = facade.getAlbumRep().GetAllAlbums();
            model.GetSelectedAlbum = id != null ? model.AllAlbums.FirstOrDefault(a => a.id == id) : model.AllAlbums.FirstOrDefault();
            return View(model);
        }

        public ActionResult CreateAlbum()
        {
            facade = new Albumfacade();
            CreateAlbumViewModel model = new CreateAlbumViewModel();
            model.GetAllArtists = facade.GetArtistRep().GetAllArtist();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddAlbum(AlbumModel model)
        {
            facade = new Albumfacade();
            facade.getAlbumRep().CreateAlbum(new Album { title = model.Title, artistId = model.Artist, price = model.Price, genreId = model.Genre, albumArtURL = model.AlbumArtUrl, songSampleURL = model.SongSampleUrl, releaseDate = model.ReleaseDate });
            return RedirectToAction("Index");
        }
    }
}
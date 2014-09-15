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
        //IAlbumRepository rep = new AlbumRepository();
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
            return View();
        }

        [HttpPost]
        public ActionResult AddAlbum(AlbumModel model)
        {
            facade = new Albumfacade();
            facade.getAlbumRep().CreateAlbum(new Album { title = model.Title, artistId = model.Artist, price = model.Price, genreId = model.Genre, albumArtURL = model.AlbumArtUrl, songSampleURL = model.SongSampleUrl, releaseDate = model.ReleaseDate});
            return RedirectToAction("Index");
        }


    }
}
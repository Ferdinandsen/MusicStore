using DAL;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class GenreController : Controller
    {
        DAL.DataAccessLayerfacade facade;
        // GET: Genre
        public ActionResult Index()
        {
            facade = new DataAccessLayerfacade();
            AlbumViewModels model = new AlbumViewModels();
            model.AllGenres = facade.GetGenreRep().GetAllGenres();
            return View(model);
        }
        public ActionResult CreateGenre()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateGenre(GenreModel model)
        {
            facade = new DataAccessLayerfacade();
            facade.GetGenreRep().CreateGenre(new Genre { name = model.Name });
            return RedirectToAction("Index");
        }
    }
}
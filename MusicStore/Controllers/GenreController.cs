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
        DataAccessLayerfacade _facade;
        private GenreViewModel _model;

        public ActionResult Index(int? id)
        {
            _facade = new DataAccessLayerfacade();
            var model = new GenreViewModel();
            if (_facade.GetGenreRep().GetAllGenres().Count == 0)
            {
                model.AllGenres = _facade.GetGenreRep().GetAllGenres();
            }
            else
            {
                model.AllGenres = _facade.GetGenreRep().GetAllGenres();
                model.GetSelectedGenre = id != null ? model.AllGenres.FirstOrDefault(a => a.id == id) : model.AllGenres.FirstOrDefault();
            }
            return View(model);
        }
        public ActionResult CreateGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGenre(GenreModel model)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetGenreRep().CreateGenre(new Genre { name = model.Name });
            return RedirectToAction("Index");
        }

        public ActionResult UpdateGenre(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new GenreViewModel();
            _model.GetSelectedGenre = _facade.GetGenreRep().GetGenreById(id);
            return View(_model);
        }
        [HttpPost]
        public ActionResult UpdateGenre(Genre genre)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetGenreRep().UpdateGenre(genre);
            return RedirectToAction("Index");
        }
    }

}
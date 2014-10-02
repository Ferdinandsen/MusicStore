using DAL;
using MusicStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class GenreController : Controller
    {
        DataAccessLayerfacade _facade;
        GenreViewModel _model;

        public ActionResult Index(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new GenreViewModel();
            if (_facade.GetGenreRep().GetAllGenres().Count == 0)
            {
                _model.AllGenres = _facade.GetGenreRep().GetAllGenres();
            }
            else
            {
                _model.AllGenres = _facade.GetGenreRep().GetAllGenres();
                _model.GetSelectedGenre = id != null ? _model.AllGenres.FirstOrDefault(a => a.id == id) : _model.AllGenres.FirstOrDefault();
            }
            return View(_model);
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

        public ActionResult DeleteGenre(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new GenreViewModel();

            _model.GetSelectedGenre = _facade.GetGenreRep().GetGenreById(id);
            return View(_model);
        }

        [HttpPost]
        public ActionResult DeleteGenre(int id)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetGenreRep().DeleteGenre(id);
            return RedirectToAction("Index");
        }
    }

}
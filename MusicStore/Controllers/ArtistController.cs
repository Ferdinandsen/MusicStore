using DAL;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class ArtistController : Controller
    {
        DataAccessLayerfacade _facade;
        ArtistViewModel _model;
        // GET: Artist
        public ActionResult Index(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new ArtistViewModel();
            if (_facade.GetArtistRep().GetAllArtist().Count == 0)
            {
                _model.AllArtists = _facade.GetArtistRep().GetAllArtist();
            }
            else
            {
                _model.AllArtists = _facade.GetArtistRep().GetAllArtist();
                _model.GetSelectedArtist = id != null ? _model.AllArtists.FirstOrDefault(a => a.id == id) : _model.AllArtists.FirstOrDefault();
            }
            return View(_model);
        }

        public ActionResult CreateArtist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateArtist(ArtistModel model)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetArtistRep().CreateArtist(new Artist { name = model.Name });
            return RedirectToAction("Index");
        }

        public ActionResult UpdateArtist(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new ArtistViewModel();
            _model.GetSelectedArtist = _facade.GetArtistRep().GetArtistById(id);
            return View(_model);
        }

        [HttpPost]
        public ActionResult UpdateArtist(Artist artist)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetArtistRep().UpdateArtist(artist);
            return RedirectToAction("Index");
        }

        
        public ActionResult DeleteArtist(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new ArtistViewModel();
            _model.GetSelectedArtist = _facade.GetArtistRep().GetArtistById(id);
            return View(_model);
        }

        [HttpPost]
        public ActionResult DeleteArtist(int id)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetArtistRep().DeleteArtist(id);
            return RedirectToAction("Index");
        }
    }
}
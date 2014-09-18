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
        DataAccessLayerfacade facade;
        ArtistViewModel model;
        // GET: Artist
        public ActionResult Index(int? id)
        {
            facade = new DataAccessLayerfacade();
            model = new ArtistViewModel();
            if (facade.GetArtistRep().GetAllArtist().Count == 0)
            {
                model.AllArtists = facade.GetArtistRep().GetAllArtist();
            }
            else
            {
                model.AllArtists = facade.GetArtistRep().GetAllArtist();
                model.GetSelectedArtist = id != null ? model.AllArtists.FirstOrDefault(a => a.id == id) : model.AllArtists.FirstOrDefault();
            }
            return View(model);
        }

        public ActionResult CreateArtist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateArtist(ArtistModel model)
        {
            facade = new DataAccessLayerfacade();
            facade.GetArtistRep().CreateArtist(new Artist {name = model.Name });
            return RedirectToAction("Index");
        }
    }
}
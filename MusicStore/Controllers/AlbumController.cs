using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Repository;
using DAL.Repository.Impl;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        IRepository albumRep = new Repository();
        // GET: Album
        public ActionResult Index(){
            return View(albumRep.GetAllAlbums());
        }
         
        public ActionResult AddAlbum()
        {
            return View();
        }

    [HttpPost]
        public ActionResult AddAlbum()
        {
            return View();
        }
    }
}
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

        Repository rep = new Repository();
        // GET: Album
        public ActionResult Index(){
         
            Console.WriteLine("WWWWWWWWWWWWWWWW" + rep.GetAllAlbums().Count());
            return View(rep.GetAllAlbums());
        }
    }
}
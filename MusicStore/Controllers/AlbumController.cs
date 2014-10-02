using DAL;
using MusicStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        private DataAccessLayerfacade _facade;
        private AlbumViewModels _model;

        // GET: Album
        public ActionResult Index(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new AlbumViewModels();
         
            if (_facade.GetAlbumRep().GetAllAlbums().Count == 0)
            {
                _model.AllAlbums = _facade.GetAlbumRep().GetAllAlbums();
            }
            else
            {
                _model.AllAlbums = _facade.GetAlbumRep().GetAllAlbums();
                _model.GetSelectedAlbum = id != null
                    ? _model.AllAlbums.FirstOrDefault(a => a.id == id)
                    : _model.AllAlbums.FirstOrDefault();
            }
            return View(_model);
        }

        public ActionResult CreateAlbum()
        {
            _facade = new DataAccessLayerfacade();
            var model = new AlbumViewModels();
            model.AllArtists = _facade.GetArtistRep().GetAllArtist();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddAlbum(AlbumModel model)
        {
            _facade = new DataAccessLayerfacade();
            _facade.GetAlbumRep()
                .CreateAlbum(new Album
                {
                    title = model.Title,
                    artistId = model.Artist,
                    price = model.Price,
                    genreId = model.Genre,
                    albumArtURL = model.AlbumArtUrl,
                    songSampleURL = model.SongSampleUrl,
                    releaseDate = model.ReleaseDate
                });
            return RedirectToAction("Index");
        }

        public ActionResult UpdateAlbum(int? id)
        {
            _facade = new DataAccessLayerfacade();
            _model = new AlbumViewModels();
            _model.GetSelectedAlbum = _facade.GetAlbumRep().GetAlbumById(id);
            return View(_model);
        }
    }
}
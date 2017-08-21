using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int id)
        {
            var comicBook = _comicBookRepository.GetComicBook(id);

            return View(comicBook);
        }
    }
}
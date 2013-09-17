using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MvcBookStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        BSEntity db = new BSEntity();
        [OutputCache(Duration=10)]
      // [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            var model = db.books.ToList();
            return View(model);
        }

        [OutputCache(Duration = 120)]
        public ActionResult Genshow(int id)
        {
            ViewBag.Wise = "Genre Wise Listings";
            List<Book> allBooks = db.books.ToList();
            List<Book> genreBooks = allBooks.Where(x => x.GenreId == id).ToList();           
            return PartialView("_shows", genreBooks);
            
        }


        public ActionResult Writershow(int id)
        {
            ViewBag.Wise = "Writer Wise Listings";
            List<Book> allBooks = db.books.ToList();
            List<Book> writerBooks = allBooks.Where(x => x.WriterId == id).ToList();
            return PartialView("_shows", writerBooks);
        }
       
       [OutputCache(Duration = 20)]
        public ActionResult _Details(int id)
        {
            var model = db.books.Find(id);
            return PartialView(model);
        }

       [HttpGet]
       public ActionResult method(int id,string lang)
       {

           culture model = new culture();
           try
           {
               if (id == model.GenreId && lang != model.Culture)
               {
                   return View("np", model);
               }
               else

                   id = model.GenreId;
               lang = model.Culture;

               return View("en", model);
           }
           catch
           {
               return View();
           }

       }
        
    }

}

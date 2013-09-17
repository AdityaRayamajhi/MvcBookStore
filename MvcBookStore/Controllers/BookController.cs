using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MvcBookStore.Controllers
{
    [Authorize(Roles="Admin")]
   
    public class BookController : Controller
    {
        //
        // GET: /Book/
        BSEntity db = new BSEntity();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var modelB = db.books.ToList();
            return View(modelB);
        }

        //
        // GET: /Book/Details/5

        public ActionResult Details(int id)
        {
            Book book1 = db.books.Find(id);
            
            return View(book1);
        }

        //
        // GET: /Book/Create
      
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.genres, "GenreId", "Genre");
            ViewBag.WriterId = new SelectList(db.writers, "WriterId", "Writer");
            return View();
        }

        //
        // POST: /Book/Create

        [HttpPost]
        public ActionResult Create(Book book1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.books.Add(book1);
                    db.SaveChanges();         
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.GenreId = new SelectList(db.genres, "GenreId", "Genre",book1.BookId);
                    ViewBag.WriterId = new SelectList(db.writers, "WriterId", "Writer",book1.WriterId);
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Book/Edit/5
      
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Book book3 = db.books.Find(id);
            ViewBag.GenreId = new SelectList(db.genres, "GenreId", "Genre", book3.BookId);
            ViewBag.WriterId = new SelectList(db.writers, "WriterId", "Writer", book3.WriterId);
            return View(book3);
        }

        //
        // POST: /Book/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Book book3)
        {
            try
            {

                if (ModelState.IsValid)
                {                   
                    db.Entry(book3).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();                    
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Book/Delete/5
       
        [HttpGet]
        public ActionResult Delete(int id)
        {
             Book book4 = db.books.Find(id);
            /*   if (genre4 == null)
                 {
                     return HttpNotFound();
                 }*/
            return View(book4);
        }

        //
        // POST: /Book/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConformed(int id)
        {
             
            try
            {
                // TODO: Add delete logic here
                Book book4 = db.books.Find(id);
               if (book4 == null)
                 {
                     return HttpNotFound();
                 }
                else if (ModelState.IsValid)
                    {
                        db.books.Remove(book4);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                   } 
                else
                {
                   return View();
                }
            }
            catch
            {
                return View();
            }
        }


        // partial delete action
     
        [HttpDelete]
        public ActionResult _Delete(int id)
        {

                 // TODO: Add delete logic here
                Book book = db.books.Find(id);
                if (book == null)
                {
                    return HttpNotFound();
                }
                else if (ModelState.IsValid)
                {
                    db.books.Remove(book);
                    db.SaveChanges();                       
                }
                return RedirectToAction("Index");
        }
    }
}


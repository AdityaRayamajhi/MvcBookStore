using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Controllers
{
    public class GenreController : Controller
    {
        //
        // GET: /Genre/
        BSEntity db = new BSEntity();
        public ActionResult Index()
        {
            var model = db.genres.ToList();
            return View(model);
        }
       
        //
        // GET: /Genre/Details/5

        public ActionResult Details(int id)
        {
            genreModel genre3 = db.genres.Find(id);
         /*   if (genre3 == null)
            {
                return HttpNotFound();
            }*/
            return View(genre3);
        }

        //
        // GET: /Genre/Create
  //      [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            //Alternate use of Viewbags instead of model........
            ViewBag.genres = db.genres.ToList();
            return View();
        }

        //
        // POST: /Genre/Create
        [HttpPost]
        
        public ActionResult Create(genreModel genre1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.genres.Add(genre1);
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
        // GET: /Genre/Edit/5

        public ActionResult Edit(int id)
        {
            genreModel genre2 = db.genres.Find(id);
            if (genre2 == null)
                {
                    return HttpNotFound();
                }
            return View(genre2);
        }

        //
        // POST: /Genre/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, genreModel genre2)
        {
           try
           {
           if (genre2 == null)
                 {
                     return HttpNotFound();
                 }
                else if (ModelState.IsValid)
                    {
                        db.Entry(genre2).State = System.Data.Entity.EntityState.Modified;
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
        // GET: /Genre/Delete/5

        public ActionResult Delete(int id)
        {
            genreModel genre4= db.genres.Find(id);
       /*   if (genre4 == null)
            {
                return HttpNotFound();
            }*/
            return View(genre4);
        }

        //
        // POST: /Genre/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            
            try
            {
                // TODO: Add delete logic here
                genreModel genre4 = db.genres.Find(id);
               if (genre4 == null)
                 {
                     return HttpNotFound();
                 }
                else if (ModelState.IsValid)
                    {
                        db.genres.Remove(genre4);
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
    }
}

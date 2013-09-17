using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MvcBookStore.Controllers
{
    public class WriterController : Controller
    {
        //
        // GET: /Writer/
        BSEntity db = new BSEntity();
        public ActionResult Index()
        {
            var Model = db.writers.ToList();
            return View(Model);
        }

        //
        // GET: /Writer/Details/5

        public ActionResult Details(int id)
        {
            writer writer1 = db.writers.Find(id);
            if (writer1 == null)
            {
                return HttpNotFound();
            }
            return View(writer1);
        }

        //
        // GET: /Writer/Create

        public ActionResult Create()
        {
            ViewBag.writers = db.writers.ToList();
            return View();
        }

        //
        // POST: /Writer/Create

        [HttpPost]
        public ActionResult Create(writer writer2)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.writers.Add(writer2);
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
        // GET: /Writer/Edit/5

        public ActionResult Edit(int id)
        {
            writer writer3 = db.writers.Find(id);

            return View(writer3);
        }

        //
        // POST: /Writer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, writer writer3)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Entry(writer3).State = System.Data.Entity.EntityState.Modified;
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
        // GET: /Writer/Delete/5

        public ActionResult Delete(int id)
        {
            writer movie = db.writers.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Writer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, writer writer4)
        {
            writer movie = db.writers.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            db.writers.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

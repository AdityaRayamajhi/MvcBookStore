using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Controllers
{
    public class CultureController : Controller
    {
        //
        // GET: /Culture/
        BSEntity db = new BSEntity();
        public ActionResult Index()
        {
            var model = db.cultures.ToList();
            return View(model);
        }

        public ActionResult method(int id, string culture)
        {
            var model = db.cultures.ToList();
            return View();
        }
        
        //
        // GET: /Culture/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Culture/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Culture/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Culture/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Culture/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Culture/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Culture/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTest1.Controllers
{
    public class HappyController : Controller
    {
        // GET: Happy
        public ActionResult Index()
        {
           // return "this is my <b>default</b> action...";
            return View();
        }

        // GET: Happy
        public ActionResult HappyList()
        {
            // return "this is my <b>default</b> action...";
            return View();
        }


        // GET: Happy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Happy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Happy/Create
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

        // GET: Happy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Happy/Edit/5
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

        // GET: Happy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Happy/Delete/5
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

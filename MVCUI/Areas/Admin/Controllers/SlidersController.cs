using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BL;

namespace MVCUI.Areas.Admin.Controllers
{
    public class SlidersController : Controller
    {
        SliderManager manager = new SliderManager();
        // GET: Admin/Sliders
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Sliders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Sliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Sliders/Create
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

        // GET: Admin/Sliders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Sliders/Edit/5
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

        // GET: Admin/Sliders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Sliders/Delete/5
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

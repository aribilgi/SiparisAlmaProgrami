using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities; // CRUD için gerekli
using BL; // CRUD için gerekli

namespace MVCUI.Areas.Admin.Controllers
{
    public class AddressesController : Controller
    {
        
        // GET: Admin/Addresses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Addresses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Addresses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Addresses/Create
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

        // GET: Admin/Addresses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Addresses/Edit/5
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

        // GET: Admin/Addresses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Addresses/Delete/5
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

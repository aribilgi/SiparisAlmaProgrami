using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BL;
using System.IO; // Dosya işlemleri için gerekli

namespace MVCUI.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        ProductManager manager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        // GET: Admin/Products
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase Image)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid) // Modelin(product) durumu geçerliyse
                {
                    if (Image != null) // Resim seçilmişse
                    {
                        var filename = Path.GetFileName(Image.FileName);
                        var path = Path.Combine(Server.MapPath("/Images"), filename);
                        Image.SaveAs(path); // Resmi sunucuya farklı kaydet yöntemiyle yükledik
                        product.Image = Image.FileName;
                    }
                    product.CreateDate = DateTime.Now;
                    manager.Add(product);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("","Hata Oluştu! Kayıt Eklenemedi!"); // Eğer hata oluşursa bunu modelstate e ekle ve kullanıcıya göster.
            }
            ViewBag.CategoryId = new SelectList(categoryManager.GetAll(), "Id", "Name");
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Products/Edit/5
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

        // GET: Admin/Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Products/Delete/5
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

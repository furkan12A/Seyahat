using Seyahat.Models.DataContext;
using Seyahat.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    public class HizmetController : Controller
    {

         KurumsalDBContext  db = new KurumsalDBContext();
        // GET: Hizmet
        public ActionResult Index()
        {
            return View(db.Hizmet.ToList());
        }
        
        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Hizmet hizmet,HttpPostedFileBase ResimURL)
        {
            if (ModelState.IsValid)
            {
                if (ResimURL != null)
                {
              
                    FileInfo imginfo = new FileInfo(ResimURL.FileName);
                    WebImage img = new WebImage(ResimURL.InputStream);

                    string logoname = Guid.NewGuid().ToString() + imginfo.Extension;
                    img.Resize(200, 300);
                    img.Save("~/Uploads/Hizmet/" + logoname);

                    hizmet.ResimURL = "/Uploads/Hizmet/" + logoname;
                } 

                db.Hizmet.Add(hizmet);  
                db.SaveChanges();
                return RedirectToAction("Index");


            }

            return View(hizmet);

        }

        public ActionResult Edit(int ? id)
        {

            if (id == null)
            {

                ViewBag.Uyari = "Güncellenecek Hizmet Bulunmadı";

            }

            var hizmet = db.Hizmet.Find(id);

            if (hizmet == null)
            {
                return HttpNotFound();

            }


            return View(hizmet);

        }
        [HttpPost]
        public ActionResult Edit(int ? id, Hizmet hizmet,HttpPostedFileBase ResimURL )
        {
            if (!ModelState.IsValid)
            {
                db.Entry(hizmet).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");

            }


              return View ();  

        }
    }
}
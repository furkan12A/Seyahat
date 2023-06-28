using Seyahat.Models.DataContext;
using Seyahat.Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    public class KimlikController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Kimlik
        public ActionResult Index()
        {
            return View(db.Kimlik.ToList()); 
        }

    

      

        // GET: Kimlik/Edit/5
        public ActionResult Edit(int id)
        {
            var kimlik = db.Kimlik.Where(k=>k.KimlikId==id).SingleOrDefault();
            return View(kimlik);
        }

        // POST: Kimlik/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Kimlik kimlik,HttpPostedFileBase LogoURL)
        {
            if (ModelState.IsValid)
            {

                var k = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
                    if (LogoURL != null)
                    {
                        if (System.IO.File.Exists(Server.MapPath(kimlik.LogoURL)))
                        {
                            System.IO.File.Delete(Server.MapPath(kimlik.LogoURL));
                        }
                        FileInfo imginfo = new FileInfo(LogoURL.FileName);
                        WebImage img = new WebImage(LogoURL.InputStream);

                    string logoname = Guid.NewGuid().ToString() + imginfo.Extension;
                    img.Resize(200,300);
                    img.Save("~/Uploads/Kimlik/" + logoname);

                    kimlik.LogoURL = "/Uploads/Kimlik/" + logoname;
                }
                k.Title= kimlik.Title;
                k.Keywords = kimlik.Keywords;
                k.Description = kimlik.Description;
                k.Unvan=kimlik.Unvan;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

  
    }
}

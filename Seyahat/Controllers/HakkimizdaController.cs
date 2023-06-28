using Seyahat.Models.DataContext;
using Seyahat.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    public class HakkimizdaController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Hakkimizda
        public ActionResult Index()
        {
            var h = db.Hakkımızda.ToList();
            return View(h);
        }

        public ActionResult Edit(int id)
        {
            var h = db.Hakkımızda.Where(x=>x.HakkımızdaId==id).FirstOrDefault();

            return View(h); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(int id,Hakkımızda h)
        {

            if (ModelState.IsValid)
            {
                var hakkımızda = db.Hakkımızda.Where(x => x.HakkımızdaId == id).SingleOrDefault();

                hakkımızda.Acıklama = h.Acıklama;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
          

            return View();

        }
    }
}
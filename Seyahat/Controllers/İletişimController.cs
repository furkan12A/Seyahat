using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Seyahat.Models.DataContext;
using Seyahat.Models.Model;

namespace Seyahat.Controllers
{
    public class İletişimController : Controller
    {
        private KurumsalDBContext db = new KurumsalDBContext();

        // GET: İletişim
        public ActionResult Index()
        {
            return View(db.İletişim.ToList());
        }

        // GET: İletişim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            İletişim İletişim = db.İletişim.Find(id);
            if (İletişim == null)
            {
                return HttpNotFound();
            }
            return View(İletişim);
        }

        // GET: İletişim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: İletişim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "İletişimId,Adres,Telefon,Fax,Whatsapp,Facebbok,Twitter,İnstagram")] İletişim İletişim)
        {
            if (ModelState.IsValid)
            {
                db.İletişim.Add(İletişim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(İletişim);
        }

        // GET: İletişim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            İletişim İletişim = db.İletişim.Find(id);
            if (İletişim == null)
            {
                return HttpNotFound();
            }
            return View(İletişim);
        }

        // POST: İletişim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "İletişimId,Adres,Telefon,Fax,Whatsapp,Facebbok,Twitter,İnstagram")] İletişim İletişim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(İletişim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(İletişim);
        }

        // GET: İletişim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            İletişim İletişim = db.İletişim.Find(id);
            if (İletişim == null)
            {
                return HttpNotFound();
            }
            return View(İletişim);
        }

        // POST: İletişim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            İletişim İletişim = db.İletişim.Find(id);
            db.İletişim.Remove(İletişim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

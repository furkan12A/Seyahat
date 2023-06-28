using Seyahat.Models.DataContext;
using Seyahat.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    
    public class AdminController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategori.ToList();
            return View(sorgu);

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();//Eşleşen E posta VArmı
            if (login.Eposta==admin.Eposta && login.Sifre==admin.Sifre)
            {
                Session["adminid"] = login.AdminId;
                Session["eposta"] = login.Eposta;
                 
                return RedirectToAction("Admin", "Index");
            }
            ViewBag.Uyari = "Hatalı Giriş";
            return View(admin);
        }

        public ActionResult Logot()
        {


            return View();
        }
    }
 
}
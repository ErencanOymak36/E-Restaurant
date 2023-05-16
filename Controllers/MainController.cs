using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Restaurant.Models.Classes;

namespace E_Restaurant.Controllers
{
    public class MainController : Controller
    {
        Context db = new Context();
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult ShopPage()
        {
            var degerler = db.Foods.ToList();
           
            return View(degerler);
        }
        public ActionResult Arasoguk()
        {
            var degerler= db.Foods.ToList();
            return View(degerler);
        }
        public ActionResult Arasıcak()
        {
            var degerler = db.Foods.ToList();
            return View(degerler);
        }
        public ActionResult AnaYemek()
        {
            var degerler = db.Foods.ToList();
            return View(degerler);
        }
        public ActionResult Sogukİ()
        {
            var degerler = db.Drinks.ToList();
            return View(degerler);
        }
        public ActionResult Sıcakİ()
        {
            var degerler = db.Drinks.ToList();
            return View(degerler);
        }
        public ActionResult Alkolİ()
        {
            var degerler = db.Drinks.ToList();
            return View(degerler);
        }
        public ActionResult Serpme()
        {
            var degerler = db.Breakfasts.ToList();
            return View(degerler);
        }
        public ActionResult Bufe()
        {
            var degerler = db.Breakfasts.ToList();
            return View(degerler);
        }
        //sütlü tatlılar
        public ActionResult SutluT()
        {
            var degerler = db.Desserts.ToList();
            return View(degerler);
        }
        // şerbetli tatlılar
        public ActionResult SerbetliT()
        {
            var degerler = db.Desserts.ToList();
            return View(degerler);
        }
        // çikolatalı tatlılar
        public ActionResult CT()
        {
            var degerler = db.Desserts.ToList();
            return View(degerler);
        }
        public ActionResult Salata()
        {
            var degerler = db.Salads.ToList();
            return View(degerler);
        }
        // Öğrenci Menü
        public ActionResult Om()
        {
            var degerler = db.StudentMenus.ToList();
            return View(degerler);
        }
        // Popüler Menü
        public ActionResult Pm()
        {
            var degerler = db.PopularMenus.ToList();
            return View(degerler);
        }


    }
}
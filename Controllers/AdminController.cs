using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using E_Restaurant.Models.Classes;

namespace E_Restaurant.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String;
        }
        [HttpGet]
        public ActionResult LoginForAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForAdmin(FormCollection bilgi)
        {
            string kullanıcıad = bilgi["kullanıcıad"].ToString();
            string password = GetMD5(bilgi["password"].ToString());
            var count = db.MyProperty.Where(x => x.AdminName == kullanıcıad && x.Password == password).Count();

            if (count == 0)
            {
                ViewData["sonuc"] = "SİSTEME GİRİŞ İZNİNİZ BULUNMAMAKTADIR!!!!";
            }
            else
            {
                Session["session_Login"] = true;
                Session["session_kullanıcıad"] = kullanıcıad;
                ViewData["sonuc"] = "GİRİŞ BAŞARILI YÖNLENDİRİLME İÇİN LÜTFEN BİR KAÇ SANİYE BEKLEYİN.";
                return RedirectToAction("Foods", "Admin");
            }
            return RedirectToAction("LoginForAdmin", "Admin");
        }

        [HttpGet]
        public ActionResult LoginForUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForUser(FormCollection bilgi)
        {
            string username = bilgi["kullanıcıad"].ToString();
            string password = GetMD5(bilgi["password"].ToString());
            var count = db.MyProperty.Where(x => x.AdminName == username && x.Password == password).Count();

            if (count == 0)
            {
                ViewData["sonuc"] = "SİSTEME GİRİŞ İZNİNİZ BULUNMAMAKTADIR!!!!";
            }
            else
            {
                Session["session_Login"] = true;
                Session["session_kullanıcıad"] = username;
                ViewData["sonuc"] = "GİRİŞ BAŞARILI YÖNLENDİRİLME İÇİN LÜTFEN BİR KAÇ SANİYE BEKLEYİN.";
                return RedirectToAction("HomePage", "Main");
            }
            return RedirectToAction("LoginForUser","Admin");
        }
        public ActionResult Foods()
        {
            var degerler = db.Foods.ToList();
            return View(degerler);
        }
        public ActionResult Drinks()
        {
            var degerler = db.Drinks.ToList();
            return View(degerler);
        }
        public ActionResult Desserts()
        {
            var degerler = db.Desserts.ToList();
            return View(degerler);
        }
        public ActionResult Breakfasts()
        {
            var degerler = db.Breakfasts.ToList();
            return View(degerler);
        }
        public ActionResult Salads()
        {
            var degerler = db.Salads.ToList();
            return View(degerler);
        }
        public ActionResult StudentMenus()
        {
            var degeler = db.StudentMenus.ToList();
            return View(degeler);
        }
        public ActionResult PopularMenus()
        {
            var degerler = db.PopularMenus.ToList();
            return View(degerler);
        }
        //------------------------------------------------------------------
        //------------------------------------------------------------
        // yemek ekleme
        [HttpGet]
        public ActionResult AddFood()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFood(Foods p1)
        {
            db.Foods.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Foods");
        }


        // içecek ekleme
        [HttpGet]
        public ActionResult AddDrink()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDrink(Drinks p1)
        {
            db.Drinks.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Drinks");
        }

        // tatlı ekleme
        [HttpGet]
        public ActionResult AddDessert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDessert(Desserts p1)
        {
            db.Desserts.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Desserts");
        }

        // kahvaltı ekleme
        [HttpGet]
        public ActionResult AddBreakfast()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBreakfast(Breakfasts p1)
        {
            db.Breakfasts.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Breakfasts");
        }

        // salata ekleme
        [HttpGet]
        public ActionResult AddSalad()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSalad(Salads p1)
        {
            db.Salads.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Salads");
        }

        // Öğrenci menü ekleme
        [HttpGet]
        public ActionResult AddStudenMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudenMenu(StudentMenu p1)
        {
            db.StudentMenus.Add(p1);
            db.SaveChanges();
            return RedirectToAction("StudentMenus");
        }

        // popüler menü ekleme
        [HttpGet]
        public ActionResult AddPopularMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPopularMenu(PopularMenu p1)
        {
            db.PopularMenus.Add(p1);
            db.SaveChanges();
            return RedirectToAction("PopularMenus");
        }
    }
}
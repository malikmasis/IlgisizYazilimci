using Entites;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        List<Blog> kitaplar = new List<Blog>
            {
                new Blog{ Id = 1, KeyWords = "Veysel Uğur KIZMAZ", Content = "Asp.Net MVC 5", ViewCount= 34},
                new Blog{ Id = 2, KeyWords = "Veysel Uğur KIZMAZ", Content = "C# ile Asp.Net 4.5", ViewCount= 36},
                new Blog{ Id = 3, KeyWords = "Burak TUNGUT", Content = "Algoritma ve Programlama Mantığı", ViewCount= 28},
                new Blog{ Id = 4, KeyWords = "Muhammed ÖNAL", Content = "RFID", ViewCount= 33},
                new Blog{ Id = 5, KeyWords = "Süleyman UZUNKÖPRÜ", Content = "Visual Studio 2013", ViewCount= 35},
                new Blog{ Id = 6, KeyWords = "Süleyman UZUNKÖPRÜ", Content = "PROJELER İLE C# 5.0 VE SQL SERVER 2012", ViewCount= 49}
            };

        public ActionResult Index()
        {
            BusinessLayer.Test test = new BusinessLayer.Test();
            return View();
        }
        [HttpGet]
        public ActionResult Index(int sayfa = 1)
        {
            //return View(kitaplar.OrderBy(x => x.KeyWords).ToPagedList(sayfa, 2));

            return View(Tuple.Create<IPagedList<Entites.Blog>, Category>(kitaplar.OrderBy(x => x.KeyWords).ToPagedList(sayfa, 2), new Category()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Sayfası";

            return View();
        }
    }
}
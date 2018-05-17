using Entites;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<Blog> kitaplar = new List<Blog>
        {
    
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="Malik"}, Id = 1, Title = "Asp ile geliştirme", Content = "Asp.Net MVC 5 dsad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.33333333333", ViewCount= 34},
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="Cem"}, Title = "C# ile Asp.Net 4.5 a", Content = "C# ile Asp.Net 4.5 ad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, ", ViewCount= 36},
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="Ecem"}, Title = "Algoritma geliştirme", Content = "Algoritma ve Programlama Mantığı ad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod,", ViewCount= 28},
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="Gökhan"}, Title = "RFID konular", Content = "RFID ad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod,", ViewCount= 33},
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="Doğukan"}, Title = "Visual Studio 2014 anlatımı", Content = "Visual Studio 2013 ad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod,", ViewCount= 35},
            new Blog{ CreatedDate = DateTime.Today, CreteUser = new User(){ Id =1,Name ="System"}, Title = "PROJELER İLE C# 5.0 VE SQL SERVER 2012", Content = "PROJELER İLE C# 5.0 VE SQL SERVER 2012 ad33Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod,", ViewCount= 49}
        };
        


        List<Category> categories = new List<Category>
        {
                new Category{ Id = 1, Name = "Java" , Blogs =  kitaplar },
                new Category{ Id = 2, Name = "C#" , Blogs =  kitaplar },
                new Category{ Id = 3, Name = "Pyhton",Blogs =  kitaplar },
                new Category{ Id = 4, Name = "ASP .net MVC",Blogs =  kitaplar },
                new Category{ Id = 5, Name = "Spring Mvc",Blogs =  kitaplar },
                new Category{ Id = 6, Name = "Database",Blogs =  kitaplar }
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

            return View(Tuple.Create<IPagedList<Entites.Blog>, List<Category>>(kitaplar.OrderBy(x => x.KeyWords).ToPagedList(sayfa, 2), categories));
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
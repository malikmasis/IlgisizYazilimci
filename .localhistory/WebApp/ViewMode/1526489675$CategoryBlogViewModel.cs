using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.ViewMode
{
    public class CategoryBlogViewModel : Controller
    {
        // GET: CategoryBlogViewModel
        public ActionResult Index()
        {
            return View();
        }
    }
}
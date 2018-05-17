using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.ViewMode
{
    public class CategoryBlogViewModel
    {

        public Category Category { get; set; }
        public Blog Blog { get; set; }

    }
}
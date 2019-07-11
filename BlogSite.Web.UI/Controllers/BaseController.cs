using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data.Abstrac;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Web.UI.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICategoryResptory category;
        public BaseController(ICategoryResptory category)
        {
            this.category = category;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Insert()
        {
            ViewBag.cat = category.GetAll().ToList();
            return View();
        }
    }
}
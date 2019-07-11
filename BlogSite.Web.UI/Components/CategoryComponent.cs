using BlogSite.Data.Abstrac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlogSite.Web.UI.Components
{
    public class CategoryComponent:ViewComponent
    {
        private readonly ICategoryResptory categoryResptory;
        
        public CategoryComponent(ICategoryResptory _categoryResptory)
        {
            categoryResptory = _categoryResptory;
        }
        public IViewComponentResult Invoke()
        {
            var data = categoryResptory.GetAll().Include(x => x.Blogs).ToList();
            return View(data);
        }
    }
}

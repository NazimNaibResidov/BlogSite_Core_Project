using BlogSite.Data.Abstrac;
using BlogSite.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Data.Concrete.EfCore
{
    public  class CategoryResptory:BaseResptory<Category>, ICategoryResptory
    {
        public CategoryResptory(BlogContext context):base(context)
        {

        }
    }
    
}

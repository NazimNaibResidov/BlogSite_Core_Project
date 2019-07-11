using BlogSite.Data.Abstrac;
using BlogSite.Data.Concrete.EfCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Web.UI.Helpers
{
    public class Services
    {
        public static void Load(IServiceCollection services)
        {
            services.AddTransient<ICategoryResptory, CategoryResptory>();
            services.AddTransient<IBlogResptory, BlogResptory>();
            services.AddTransient<ICommentResptory, CommentResptory>();
        }
    }
}

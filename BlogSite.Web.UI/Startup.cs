using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data.Concrete.EfCore;
using BlogSite.Web.UI.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace BlogSite.Web.UI
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
      
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Blog"),b=>b.MigrationsAssembly("BlogSite.Web.UI")));
            Services.Load(services);
            services.AddMvc();
        }

      
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseStaticFiles();
          

        }
    }
}

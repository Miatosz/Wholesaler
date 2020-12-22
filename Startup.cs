using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wholesaler.Models;
using Wholesaler.Repositories;

namespace Wholesaler
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //  services.AddDbContext<ApplicationDbContext>(options =>
            //      options.UseSqlServer(Configuration.GetConnectionString("StudentDBConnection1")));

            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlite("Data Source=Wholesaler1.db"));    

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IShopRepository, ShopRepository>();
            services.AddTransient<IWholesalerRepository, WholesalerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IWarehouseRepository, WarehouseRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: null,
                    template: "{controller}/{action}"                    
                );

                routes.MapRoute(
                    name: null,
                    template: "{controller}",
                    defaults: new {action="List"}
                );

                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new {controller="User",Action="List"}
                );

                routes.MapRoute(
                    name: null,
                    template: "{controller}/{action}/{id?}"
                );
            });
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nonprofitOrganization.Models;
using nonprofitOrganization.Data;


namespace nonprofitOrganization
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //Code to enable a database setup using NuGet and Context Class
            services.AddDbContext<NonProfitContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("NonProfitContext"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure();
                    });
            });
            


            //Code to enable AddRouting
            services.AddRouting(options =>
            {
                //Code for Lowercase addresses and a trailing slash
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            }
            );

            //Code to configure password options
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            })
                .AddEntityFrameworkStores<NonProfitContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.Configure<CookieTempDataProviderOptions>(options => {
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            services.AddMemoryCache();
            services.AddSession();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
           
            app.UseEndpoints(endpoints =>
            {
                //Code for the .MapAreaControllerRoute for the Admin area DP.
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Question}/{action=Index}/{id?}");

                //Code for the .MapAreaControllerRoute for the Staff area DP.
                endpoints.MapAreaControllerRoute(
                    name: "staff",
                    areaName: "Staff",
                    pattern: "Staff/{controller=Question}/{action=Index}/{id?}");

                //Code for the .MapAreaControllerRoute for the Help area DP.
                endpoints.MapAreaControllerRoute(
                    name: "help",
                    areaName: "Help",
                    pattern: "Help/{controller=Help}/{action=Index}/{id?}");


                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // Code to seed database with initial roles and users DP.
            NonProfitContext.CreateAdminUser(app.ApplicationServices).Wait();
        }
    }
}

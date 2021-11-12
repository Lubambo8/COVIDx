using CovidXWebApp.Config;
using CovidXWebApp.Services;
using CovidXWebApp.Services.Interface;
using EFCore;
using EFCore.EFCoreConfigurationMethods;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Utility.Email;

namespace CovidXWebApp
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

            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(nameof(CovidXWebApp)));


            });

            //services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            //services.AddSingleton<IConnectionStrings, ConnectionStrings>();

            services.AddDefaultIdentity<EFCoreIdentityUser>(options =>
            {
                // require email confirmation to sign in
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedEmail = false;

                // password requirements
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
            }).AddRoles<IdentityRole>().AddEntityFrameworkStores<DatabaseContext>();

            // configure cookies
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                //options.LoginPath = "/Profile/Create";
            });

           

            services.AddTransient<IPatientServices, PatientServices>();
            services.AddTransient<INurseServices, NurseService>();
            services.AddTransient<ICalendarService, CalendarService>();
            services.AddTransient<IManagerService, ManagerService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IEmailer, Emailer>();

            // configure session and memory caching
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "CovidX.Session";
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViews();
            
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
            // add session middleware
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

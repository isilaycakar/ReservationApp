using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.BusinessLayer.Container;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;
using ReservationApp.EntityLayer.Concrete;
using ReservationApp.Panel.UI.Models;

namespace ReservationApp.Panel.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Context>();
            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>();

            // EF baðýmlýlýðýný kaldýrmak için yazýldý. Ef newlemesi yapmadan readonly ile service constructor yapýlýyor.

            builder.Services.ContainerDependencies();

            //-------------------------------------------------------------------------------------
            builder.Services.AddControllersWithViews();

            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            builder.Services.AddMvc();

            //builder.Services.AddAuthentication(
            //   CookieAuthenticationDefaults.AuthenticationScheme)
            //   .AddCookie(x =>
            //   {
            //       x.LoginPath = "/Login/SignIn/";
            //   }
            //   );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
           
            app.Run();

        }
    }
}
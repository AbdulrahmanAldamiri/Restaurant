using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddScoped<IRepository<MasterCategoryMenu>, MasterCategoryMenuRepository>();
            services.AddScoped<IRepository<MasterItemMenu>, MasterItemMenuRepository>();
            services.AddScoped<IRepository<MasterMenu>, MasterMenuRepository>();
            services.AddScoped<IRepository<MasterOffer>, MasterOfferRepository>();
            services.AddScoped<IRepository<MasterPartner>, MasterPartnerRepository>();
            services.AddScoped<IRepository<MasterService>, MasterServiceRepository>();
            services.AddScoped<IRepository<MasterSlider>, MasterSliderRepository>();
            services.AddScoped<IRepository<MasterSocialMedia>, MasterSocialMediaRepository>();
            services.AddScoped<IRepository<MasterWorkingHour>, MasterWorkingHourRepository>();
            services.AddScoped<IRepository<SystemSetting>, SystemSettingRepository>();
            services.AddScoped<IRepository<TransactionBookTable>, TransactionBookTableRepository>();
            services.AddScoped<IRepository<TransactionContactUs>, TransactionContactUsRepository>();
            services.AddScoped<IRepository<TransactionNewsletter>, TransactionNewsletterRepository>();
            services.AddScoped<IRepository<MasterCustomerReview>, MasterCustomerReviewRepository>();
            services.AddDbContext<AppDbContext>(
                x =>
                {
                    x.UseSqlServer(Configuration.GetConnectionString("RestaurantDB"));
                }
                );
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.Configure<IdentityOptions>(x =>
            {
                x.Password.RequiredLength = 3;
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;



            });
            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Admin/Account/Login";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseCors();
            app.UseMvc();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern:"{area:exists}/{controller=Home}/{action=index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}"
                    );
            });
        }
    }
}

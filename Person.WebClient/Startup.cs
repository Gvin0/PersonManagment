using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Person.Domain.Interfaces;
using Person.Repository;
using Person.Services;

namespace Person.WebClient
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseLazyLoadingProxies().UseSqlServer(_configuration.GetConnectionString("PersonDbConnection")));
            services.AddMvc(/*options => options.EnableEndpointRouting = false*/);

            

            services.AddSingleton<IAppDbContext, AppDbContext>();

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPhoneNumberRepository, PhoneNumberRepository>();
            services.AddScoped<IRelationRepository, RelationRepository>();

            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPhoneNumberService, PhoneNumberService>();
            services.AddScoped<IRelationService, RelationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else // if production
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Person}/{action=Index}/{id?}");
            });

            //app.Run(async (context) =>
            //{
               
            //        await context.Response.WriteAsync("Hello World!");
                
            //});
        }
    }
}

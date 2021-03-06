using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Webgentle.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello sathish Middlewar1");
            //    await next();
            //    await context.Response.WriteAsync("Hello sathish Middlewar1 Second");

            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello sathish Middlewar2");
            //    await next();
            //    await context.Response.WriteAsync("Hello sathish Middlewar2 Second");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello sathish Middlewar3");
            //    await next();
            //});




            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/sathish", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Sathish!");
            //    });
            //});

        }
    }
}

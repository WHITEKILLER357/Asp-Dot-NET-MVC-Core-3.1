using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMVC
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
            //***********************************************
            //    Middlewares  using next() method 
            //***********************************************

            //app.Use(async(context, next)=> {
            //    await context.Response.WriteAsync("Hi white killer");

            //    await next();

            //    await context.Response.WriteAsync("\nfirst Middleware return response");
            //});

            //app.Use(async(context, next)=>
            //   {
            //       await context.Response.WriteAsync("\nsencond middleware..");

            //       await next();
            //});


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //****************************************************************
                //    Environment Variable for launchSettings.json file
                //****************************************************************

                //endpoints.MapGet("/", async context =>
                //{
                //if (env.IsDevelopment())
                //{
                //    await context.Response.WriteAsync(env.EnvironmentName);
                //}
                //else if (env.IsProduction())
                //{
                //    await context.Response.WriteAsync(env.EnvironmentName);
                //}
                //else if (env.IsStaging())
                //{
                //    await context.Response.WriteAsync(env.EnvironmentName);
                //}                   
                //else if(env.IsEnvironment("Dev"))
                //{
                //    await context.Response.WriteAsync("Dev Custome");
                //}
                //else
                //{
                //    await context.Response.WriteAsync("Testing");
                //}

                //});

                // controller class 
                endpoints.MapDefaultControllerRoute();

                
            });

            //   endpoints  "/white" in kestrel server

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/white", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello white!");
            //    });
            //});
        }
    }
}

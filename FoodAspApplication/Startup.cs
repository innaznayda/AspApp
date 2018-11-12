﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using FoodAspApplication.Services;
using FoodAspApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FoodAspApplication {
    public class Startup {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<FoodAspApplicationDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("FoodAspApplication")));
            services.AddScoped<IRestaurantData, SqlRestaurantData>();
            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }



            app.UseWelcomePage(new WelcomePageOptions {
                Path = "/welcome"
            });

            //app.UseStaticFiles();
            app.UseMvc(ConfigureRoute);

            app.Run(async (context) => {
                string greeting = greeter.GetMessageOfTheDay();
                await context.Response.WriteAsync($"{greeting} ");
            });
        }

        private void ConfigureRoute(IRouteBuilder routeBuilder) {
            // Home/Index
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");

        }
    }
}

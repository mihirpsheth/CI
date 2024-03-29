﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApplication8
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
            services.AddHealthChecksUI();
            services.AddHealthChecks()
                .AddCheck<AuthenticationHealth>("Authentication")
                .AddCheck<ReportHealth>("Report")
                .AddCheck<HelloWorldHealth>("HelloWorld");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHealthChecks("/health", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            //app.UseHealthChecksUI(config => config.UIPath = "/ui");
            app.UseHealthChecksUI(setup =>
             {
                 setup.UIPath = "/ui";
                 //setup.ApiPath = "/super-api";
                 //setup.WebhookPath = "/da-webhooks";
                 setup.ResourcesPath = "/my-resources";
             });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvc();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "api",
                //    template: "api/{controller=helloworld}/{action=get}/{5}");
                routes.MapRoute("default", "api/{controller=helloworld}/{action=get}");


            });
        }
    }
}

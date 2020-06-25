using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using IdentityServer.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IdentityServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddIdentityServer()
                .AddSigningCredential(new X509Certificate2(@"C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Certificates\identityserver.pfx", "identity"))
                .AddInMemoryIdentityResources(InMemoryConfiguration.IdentityResources())
                .AddInMemoryApiResources(InMemoryConfiguration.ApiResources())
                .AddInMemoryClients(InMemoryConfiguration.Clients())
                .AddTestUsers(InMemoryConfiguration.Users().ToList())
                .AddInMemoryApiScopes(InMemoryConfiguration.Scopes());

            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;


            services.AddMvc(option =>
            {
                option.EnableEndpointRouting = false;
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}

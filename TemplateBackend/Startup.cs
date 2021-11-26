using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TemplateBackend.Middlewares;
using TemplateBackend.Repositories;
using TemplateBackend.Repositories.Contrato;
using TemplateBackend.Repositories.Implementacao;
using TemplateBackend.Services.Contrato;
using TemplateBackend.Services.Implementacao;

namespace TemplateBackend
{
    public class Startup
    {
        private const string nomeEmpresa = "Leandro Teste";
        private const string versaoSw = "v1";


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();


            services.AddControllers();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(versaoSw, new OpenApiInfo { Title = nomeEmpresa, Version = versaoSw });

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //x.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

            });


            //dependency injection
            services.AddSingleton<IRepositoryBase, RepositoryBase>();


            //repos
            services.AddScoped<IRepositoryTeste, RepositoryTeste>();
            services.AddScoped<IRepositoryTesteInstancia, RepositoryTesteInstancia>();

            // services
            services.AddScoped<IServiceOutroTeste, ServiceOutroTeste>();
            services.AddScoped<IServiceTeste, ServiceTeste>();

            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware(typeof(ErrorMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(x =>
            {
                x.RoutePrefix = string.Empty; // apresentar swagger como default
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
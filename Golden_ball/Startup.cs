using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Golden_Ball.API.PlayerContext;
using Golden_Ball.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace Golden_Ball
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private Exception ArgumentNullException(string v)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(options => { options.EnableEndpointRouting = false; }).AddJsonOptions(o =>
            {                
                o.JsonSerializerOptions.PropertyNamingPolicy = null;
                o.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });
            services
           .AddControllersWithViews().AddNewtonsoftJson();

            services.AddTransient<IMailService, LocalMailService>();

            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=PlayerInfoDB;Trusted_Connection=True;";
            services.AddDbContext<PlayerInfoContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });
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
                app.UseExceptionHandler();
            }
            app.UseStatusCodePages();

            app.UseMvc();
            
        }
    }
}

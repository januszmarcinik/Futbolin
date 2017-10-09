using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Futbolin.Infrastructure.Services.Football.Leagues;
using Futbolin.Domain.Repositories.Football.Leagues;
using AutoMapper;
using Futbolin.Infrastructure.Mappers;
using Futbolin.Core.Settings;

namespace Futbolin.WebAPI
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
            services.Configure<GeneralSettings>(Configuration.GetSection("GeneralSettings"));
            services.AddSingleton<IMapper>(AutoMapperConfig.Initialize());

            services.AddScoped<ILeaguesRepository, LeaguesRepository>();
            services.AddScoped<ILeaguesService, LeaguesService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

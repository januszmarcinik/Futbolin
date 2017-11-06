using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Futbolin.Infrastructure.Services.Football.Leagues;
using AutoMapper;
using Futbolin.Infrastructure.Mappers;
using Futbolin.Core.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Futbolin.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Futbolin.Domain.Models.Football;

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
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration["Database:ConnectionString"]);
            });

            services.Configure<GeneralSettings>(Configuration.GetSection("General"));
            services.Configure<JwtTokenSettings>(Configuration.GetSection("JwtToken"));
            services.AddSingleton<IMapper>(AutoMapperConfig.Initialize());

            services.AddScoped<IRepository<League>, Repository<League>>();
            services.AddScoped<ILeaguesService, LeaguesService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Configuration = new OpenIdConnectConfiguration();
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = Configuration["JwtToken:Issuer"],
                        ValidateAudience = false,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtToken:Key"])),
                        ValidateLifetime = true
                    };
                });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}

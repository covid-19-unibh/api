using Covid_API.Models;
using Covid_API.Services;
using Google.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Covid_API
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
            services.Configure<MongoConnectionSettings>(Configuration.GetSection(nameof(MongoConnectionSettings)));

            services.AddSingleton<IMongoConnectionSettings>(sp => sp.GetRequiredService<IOptions<MongoConnectionSettings>>().Value);

            services.AddSingleton<CasesService>();

            services.AddCors();

            services.AddControllers();

            //services
            //    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(jwt =>
            //    {
            //        jwt.Authority = "linkFireBaseParaLoginGoogle";
            //        jwt.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuer = true,
            //            ValidIssuer = "linkFireBaseParaLoginGoogle",
            //            ValidateAudience = true,
            //            ValidAudience = "IdFireBaseParaLoginGoogle",
            //            ValidateLifetime = true
            //        };
            //    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

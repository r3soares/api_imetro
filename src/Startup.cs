using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using src.Respositories;
using src.Respositories.Infra.Databases.RealmDB;
using System.Globalization;

namespace src
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
            services.AddCors(options =>
            {
                services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
                    .AddCertificate()
                    .AddCertificateCache();
                options.AddPolicy(name: "CorsPolicy",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                        //.AllowCredentials();
                    });
            });
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
                    options.SerializerSettings.DateParseHandling = DateParseHandling.None;
                    options.SerializerSettings.Converters.Add(new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal });
                });
            //var validator = services.FirstOrDefault(s => s.ServiceType == typeof(IObjectModelValidator));
            //if (validator != null)
            //{
            //    services.Remove(validator);
            //    services.Add(new ServiceDescriptor(typeof(IObjectModelValidator), _ => new NonValidatingValidator(), ServiceLifetime.Singleton));
            //}
            services.AddSingleton(typeof(IVtrRepository<>), typeof(VtrRepository<>));
            services.AddSingleton(typeof(IMunicipiosRepository), typeof(MunicipiosRepository));
            services.AddSingleton(typeof(IServicosVtrRepository), typeof(ServicosVtrRepository));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.Use((context, next) => {
            //    context.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            //    context.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Origin", "Accept", "Content-Type" });
            //    return next.Invoke();
            //});
            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            //app.UseStaticFiles();
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

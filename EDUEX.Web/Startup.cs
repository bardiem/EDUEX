using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using EDUEX.BL;
using EDUEX.DAL;
using EDUEX.Data;
using EDUEX.Web.Helpers;
using EDUEX.Web.Middlewares;
using EDUEX.Web.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using EDUEX.Web.Resources;

namespace EDUEX.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(opt =>
                {
                    opt.SerializerSettings.DateFormatString = "yyyy-MM-dd'T'HH:mm:ss'Z'";
                    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                })
                .AddXmlSerializerFormatters()
                .AddDataAnnotationsLocalization(options => {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
                        return factory.Create("SharedResource", assemblyName.Name);
                    };
                });

            services.AddLocalization(opt => opt.ResourcesPath = "Resources");


            services.Configure<RequestLocalizationOptions>(options =>
            {
                var suportedCultures = Configuration.GetSection("SuportedCultures")?.GetChildren()?.Select(x => x.Value)?.ToArray();

                options.DefaultRequestCulture = new RequestCulture(suportedCultures[0]);

                var suportedCultureInfos = new CultureInfo[suportedCultures.Length];
                for (int i = 0; i < suportedCultures.Length; i++)
                {
                    suportedCultureInfos[i] = new CultureInfo(suportedCultures[i]);
                }

                options.SupportedCultures = suportedCultureInfos;
                options.SupportedUICultures = suportedCultureInfos;
                options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            var configurationSection = Configuration.GetSection("ConnectionStrings:DefaultConnection");
            services.AddDbContext<EduExDbContext>(options => options.UseSqlServer(configurationSection.Value));
            services.AddScoped<IEduExDbContext, EduExDbContext>();
            services.AddScoped(provider =>
                    new Func<IEduExDbContext>(() => provider.GetService<IEduExDbContext>())
                );
            services.AddScoped<IIdentityService, IdentityService>();

            RegisterBL(services);
            RegisterRepositories(services);
            RegisterAutomapper(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestLog();

            var localizeOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(localizeOptions.Value);

            app.UseRouting();
            app.UseMiddleware<CheckAuthMiddleware>();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void RegisterBL(IServiceCollection services)
        {
            var assembly = Assembly.GetAssembly(typeof(IBaseBL));

            var types = assembly.GetTypes();
            var blInterfaces = assembly.GetTypes()
                .Where(p => p.GetInterface(typeof(IBaseBL).Name) != null && p.IsInterface && p.IsPublic).ToList();

            foreach (var _interface in blInterfaces)
            {
                var type = assembly.GetTypes().FirstOrDefault(p => p.GetInterface(_interface.Name) != null && p.IsPublic);
                if (type != null)
                {
                    services.AddScoped(_interface, type);
                }
            }
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            var assembly = Assembly.GetAssembly(typeof(IBaseRepository));

            var types = assembly.GetTypes();
            var repositoryInterfaces = assembly.GetTypes()
                .Where(p => p.GetInterface(typeof(IBaseRepository).Name) != null && p.IsInterface && p.IsPublic).ToList();

            foreach (var _interface in repositoryInterfaces)
            {
                var type = assembly.GetTypes().FirstOrDefault(p => p.GetInterface(_interface.Name) != null && p.IsPublic);
                if (type != null)
                {
                    services.AddScoped(_interface, type);
                }
            }
        }

        private void RegisterAutomapper(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                var profileTypes = Assembly.GetExecutingAssembly().GetTypes()
                        .Where(p => p.IsSubclassOf(typeof(Profile))).ToList();

                foreach (var profileType in profileTypes)
                {
                    var obj = (Profile)Activator.CreateInstance(profileType);
                    mc.AddProfile(obj);
                }
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        private void AddLocalization(IApplicationBuilder app)
        {
            var suportedCultures = Configuration.GetSection("SuportedCultures")?.GetChildren()?.Select(x => x.Value)?.ToArray();
            var suportedCultureInfos = new CultureInfo[suportedCultures.Length];
            for (int i = 0; i < suportedCultures.Length; i++)
            {
                suportedCultureInfos[i] = new CultureInfo(suportedCultures[i]);
            }

            var requestLocatiozationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(suportedCultures[0]),
                SupportedCultures = suportedCultureInfos,
                SupportedUICultures = suportedCultureInfos
            };

            app.UseRequestLocalization(requestLocatiozationOptions);
        }
    }

    internal class CheckAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next.Invoke(context);
        }
    }
}

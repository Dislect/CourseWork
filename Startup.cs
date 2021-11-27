using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models;
using сoursework.Data.Models.Identity;
using сoursework.Data.Repository;
using Microsoft.AspNetCore.Identity;

namespace сoursework
{
    public class Startup
    {
        private string _connection { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _connection = Configuration.GetConnectionString("DefaultConnection");
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreDBContext>(options =>
                options.UseSqlServer(_connection));

            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<User, IdentityRole>(opts =>
                    {
                        opts.Password.RequiredLength = 3;   // минимальная длина
                        opts.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                        opts.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                        opts.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                        opts.Password.RequireDigit = false; // требуются ли цифры
                    }
                )
                .AddEntityFrameworkStores<IdentityContext>();

            services.AddTransient<BookRep>();
           
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}

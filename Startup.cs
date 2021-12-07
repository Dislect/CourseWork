using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models;
using сoursework.Data.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace сoursework
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
                    {
                        options.Password.RequiredLength = 3;   // минимальная длина пароля
                        options.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                        options.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                        options.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                        options.Password.RequireDigit = false; // требуются ли цифры
                    }
                )
                .AddEntityFrameworkStores<IdentityContext>();

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // подробные сообщения об ошибках
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            // исп. статических файлов
            app.UseStaticFiles();

            app.UseRouting();

            // подключение аутентификации и авторизации
            app.UseAuthentication();    
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

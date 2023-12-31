using Clase_asp_net.Extra;
using Microsoft.EntityFrameworkCore;

namespace Clase_asp_net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            //Conexion a DDBB
            string cadenaDeConexion = builder.Configuration.GetConnectionString("MiConexion");
            builder.Services.AddDbContext<DDBBContext>(op => op.UseSqlServer(cadenaDeConexion));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.UseSession();

            app.UseEndpoints( endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Principal}/{action=Index}/{id?}"
                    );
            });

            app.Run();
        }
    }
}
using FamilyExpenses.Interfaces;
using FamilyExpenses.Repositories;
using FamilyExpenses.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyExpenses
{
    //internal static class Program
    //{
    //    /// <summary>
    //    /// Punto de entrada principal para la aplicación.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new Form1());
    //    }
    //}

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var context = serviceProvider.GetRequiredService<ApplicationContext>();
                Application.Run(context);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configuración de la base de datos
            services.AddDbContext<FamilyExpensesDbContext>(options =>
                options.UseNpgsql("Host=localhost;Database=familyexpenses;Username=postgres;Password="));

            // Repositorios
            //services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            //services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IGastoRepository, GastoRepository>();

            // Servicios
            //services.AddScoped<IUsuarioService, UsuarioService>();
           //services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IGastoService, GastoService>();

            // Formularios
            //services.AddTransient<LoginForm>();
            //services.AddTransient<RegisterForm>();
            //services.AddTransient<MainForm>();
            //services.AddTransient<ExpenseForm>();
            //services.AddTransient<CategoryForm>();
            //services.AddTransient<ReportsForm>();

            // ApplicationContext
            services.AddSingleton<ApplicationContext>();
        }
    }
}

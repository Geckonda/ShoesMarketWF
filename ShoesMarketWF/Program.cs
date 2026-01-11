using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Enums;
using ShoesMarketWF.Repositories;

namespace ShoesMarketWF
{
    internal static class Program
    {
        public static IServiceProvider Services { get; private set; }

        public static Role CurrentRole { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Services = ConfigureServices().BuildServiceProvider();

            // Показываем логин как диалог
            var loginForm = Services.GetRequiredService<AuthForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Если логин успешен - запускаем главную форму
                var mainForm = Services.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql("User ID = postgres; database = SchoesMarket; HOST = localhost; Port = 5432; Password = 2245;"));

            // Регистрация универсального репозитория для работы с любыми сущностями
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            // Регистрация специализированного репозитория для пользователей
            services.AddScoped<IUserRepository, UserRepository>();

            // Регистрация Форм (новый экземпляр при каждом запросе)
            services.AddTransient<AuthForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<OrderForm>();

            return services; // Возвращаем настроенную коллекцию сервисов
        }
    }
}
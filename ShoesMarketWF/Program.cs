using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Entities;
using ShoesMarketWF.Enums;
using ShoesMarketWF.Repositories;

namespace ShoesMarketWF
{
    internal static class Program
    {
        private static IServiceProvider _services;

        private static Form? _currentMainForm;
        public static UserEntity? CurrentUser { get; set; }

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            _services = ConfigureServices().BuildServiceProvider();

            // Показываем форму авторизации
            ShowForm<AuthForm>();

            // Запускаем приложение
            Application.Run();
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

        public static void ShowForm<T>() where T : Form
        {
            // Закрываем текущую форму (если есть)
            if (_currentMainForm != null)
            {
                _currentMainForm.FormClosed -= OnMainFormClosed;
                _currentMainForm.Close();
                _currentMainForm = null;
            }

            // Создаем новую форму
            var form = _services!.GetRequiredService<T>();

            // Настраиваем ее как главную
            form.FormClosed += OnMainFormClosed;
            form.Show();

            _currentMainForm = form;
        }
        private static void OnMainFormClosed(object? sender, FormClosedEventArgs e)
        {
            // Если форма закрылась - завершаем приложение
            Application.Exit();
        }
    }
}
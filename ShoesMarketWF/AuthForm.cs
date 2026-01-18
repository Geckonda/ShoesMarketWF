using Microsoft.Extensions.DependencyInjection;
using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesMarketWF
{
    public partial class AuthForm : Form
    {
        private readonly IUserRepository _userRepository;
        public AuthForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        // Войти как гость
        // Событие навешено на кнопку "Вокйти как гость"
        private void asGuestBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = null;
            Program.ShowForm<MainForm>();
            this.Close(); // Закрываем текущую
        }


        // Авторизация пользователя
        // Событие навешено на кнопку "Войти"
        private void authBtn_Click(object sender, EventArgs e)
        {
            var login = loginInput.Text;
            var password = passwordInput.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Не все поля заполнены!");
                return;
            }

            var user = _userRepository.GetOne(login, password);
            if (user == null)
            {
                ShowErrorMessage("Неверное имя пользователя или пароль!");
                return;
            }

            Program.CurrentUser = user;
            Program.ShowForm<MainForm>();
            this.Close(); // Закрываем текущую
        }

        // Устанаваливает сообщение ошибки
        private void ShowErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.Visible = true;
        }

        // Событие навашано на input'ы loginInput и passwordInput
        private void inputsChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            errorMessageLabel.Visible = false;
        }
    }
}

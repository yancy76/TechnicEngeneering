using AutoEngeneering.Models;
using AutoEngeneering.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoEngeneering.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String login = LoginBox.Text;
            if (String.IsNullOrWhiteSpace(login))
            {
                App.ShowMessage("Введите логин");
                return;
            }

            String password = PassworBox.Password;
            if (String.IsNullOrWhiteSpace(password))
            {
                App.ShowMessage("Введите пароль");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                user user = db.users.FirstOrDefault(u => u.login == login && u.password == password);
                if (user == null)
                {
                    App.ShowMessage("Неверный логин или пароль");
                    return;
                }

                BaseWindow window = new BaseWindow();
                App.CurrentWindow = window;
                App.CurrentUser = user;
                window.Show();

                Close();
            });
        }
    }
}

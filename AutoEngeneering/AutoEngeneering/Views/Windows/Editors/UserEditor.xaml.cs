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

namespace AutoEngeneering.Views.Windows.Editors
{
    /// <summary>
    /// Логика взаимодействия для UserEditor.xaml
    /// </summary>
    public partial class UserEditor : Window
    {
        public user User = null;

        public UserEditor(user user = null)
        {
            InitializeComponent();

            IndustryContext.UseDatabase(db =>
            {
                employee[] employees = db.employees.ToArray();
                EmployeeBox.ItemsSource = employees;
            });

            if (user != null)
            {
                LoginBox.Text = user.login;
                PasswordBox.Text = user.password;
                EmployeeBox.SelectedValue = user.employeeid;
                User = user;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            String login = LoginBox.Text;
            if (String.IsNullOrWhiteSpace(login))
            {
                App.ShowMessage("Введите логин");
                return;
            }

            String password = PasswordBox.Text;
            if (String.IsNullOrWhiteSpace(password))
            {
                App.ShowMessage("Введите пароль");
                return;
            }

            employee employee = EmployeeBox.SelectedItem as employee;
            if (employee == null)
            {
                App.ShowMessage("Выберите сотрудника для пользователя");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                if (User == null)
                {
                    user user = new user();
                    user.login = login;
                    user.password = password;
                    user.employeeid = employee.id;

                    db.users.Add(user);
                }
                else
                {
                    user user = db.users.First(u => u.id == User.id);
                    user.login = login;
                    user.password = password;
                    user.employeeid = employee.id;

                    db.Entry(user).State = EntityState.Modified;
                }

                db.SaveChanges();
            });

            App.ShowMessage("Пользователь сохранён!");
            Close();
        }
    }
}

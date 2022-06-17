using AutoEngeneering.Models;
using AutoEngeneering.Tools;
using AutoEngeneering.Views.Windows.Editors;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoEngeneering.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            GetUsers();
        }

        private void GetUsers()
        {
            IndustryContext.UseDatabase(db =>
            {
                user[] users = db.users.ToArray();

                UsersList.ItemsSource = null;
                UsersList.ItemsSource = users;
            });
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            UserEditor editor = new UserEditor();
            editor.ShowDialog();
            GetUsers();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            user user = UsersList.SelectedItem as user;
            if (user == null)
            {
                App.ShowMessage("Выберите пользователя");
                return;
            } 

            UserEditor editor = new UserEditor(user);
            editor.ShowDialog();
            GetUsers();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            user user = UsersList.SelectedItem as user;
            if (user == null)
            {
                App.ShowMessage("Выберите пользователя");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                user existUser = db.users.FirstOrDefault(u => u.id == user.id);
                db.users.Remove(user);

                db.SaveChanges();
            });

            App.ShowMessage("Пользователь удалён");
            GetUsers();
        }

        private void UsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            user user = listBox.SelectedItem as user;
            if (user == null)
            {
                EditButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
            else
            {
                EditButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
        }
    }
}

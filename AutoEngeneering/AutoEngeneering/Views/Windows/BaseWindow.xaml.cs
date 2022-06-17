using AutoEngeneering.Views.Pages;
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
using System.Windows.Shapes;

namespace AutoEngeneering.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        public BaseWindow()
        {
            InitializeComponent();
            FrameBox.Content = new UsersPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentUser = null;
            AuthWindow window = new AuthWindow();
            window.Show();

            Close();
        }

        private void UsersButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentWindow.FrameBox.Content = new UsersPage();
        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentWindow.FrameBox.Content = new EmployeesPage();
        }

        private void MaterialsButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentWindow.FrameBox.Content = new MaterialsPage();
        }

        private void ComponentsButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentWindow.FrameBox.Content = new ComponentsPage();
        }

        private void DevicesTypesButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentWindow.FrameBox.Content = new TechnicTypesPage();
        }
    }
}

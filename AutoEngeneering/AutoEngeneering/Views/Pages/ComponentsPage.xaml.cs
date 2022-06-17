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
    /// Логика взаимодействия для ComponentsPage.xaml
    /// </summary>
    public partial class ComponentsPage : Page
    {
        public ComponentsPage()
        {
            InitializeComponent();
            GetComponents();
        }

        private void GetComponents()
        {
            IndustryContext.UseDatabase(db =>
            {
                component[] components = db.components.ToArray();

                ComponentsList.ItemsSource = null;
                ComponentsList.ItemsSource = components;
            });
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ComponentEditor editor = new ComponentEditor();
            editor.ShowDialog();

            GetComponents();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            component component = ComponentsList.SelectedItem as component;
            if (component == null)
            {
                App.ShowMessage("Выберите деталь");
                return;
            }

            ComponentEditor editor = new ComponentEditor(component);
            editor.ShowDialog();

            GetComponents();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            component component = ComponentsList.SelectedItem as component;
            if (component == null)
            {
                App.ShowMessage("Выберите деталь");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                component existComponent = db.components.FirstOrDefault(c => c.id == component.id);
                db.components.Remove(existComponent);

                db.SaveChanges();
            });

            App.ShowMessage("Деталь удалена");
        }

        private void ComponentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            component component = listBox.SelectedItem as component;
            if (component == null)
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

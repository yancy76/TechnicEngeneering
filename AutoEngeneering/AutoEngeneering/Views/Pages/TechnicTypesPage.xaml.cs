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
    /// Логика взаимодействия для TechnicTypesPage.xaml
    /// </summary>
    public partial class TechnicTypesPage : Page
    {
        public TechnicTypesPage()
        {
            InitializeComponent();
            GetTechnicTypes();
        }

        private void GetTechnicTypes()
        {
            IndustryContext.UseDatabase(db =>
            {
                technic_types[] types = db.technic_types.ToArray();

                TechnicsList.ItemsSource = null;
                TechnicsList.ItemsSource = types;
            });
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            TechnicTypesEditor editor = new TechnicTypesEditor();
            editor.ShowDialog();

            GetTechnicTypes();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            technic_types type = TechnicsList.SelectedItem as technic_types;
            if (type == null)
            {
                App.ShowMessage("Выберите технику");
                return;
            }

            TechnicTypesEditor editor = new TechnicTypesEditor(type);
            editor.ShowDialog();

            GetTechnicTypes();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            technic_types type = TechnicsList.SelectedItem as technic_types;
            if (type == null)
            {
                App.ShowMessage("Выберите технику");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                db.technic_types.Remove(type);
                db.SaveChanges();
            });

            App.ShowMessage("Техника удалена");
            GetTechnicTypes();
        }

        private void TechnicsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListBox listBox = sender as ListBox;
            technic_types type = listBox.SelectedItem as technic_types;
            if (type == null)
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

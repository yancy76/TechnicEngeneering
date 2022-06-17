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
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        public material Material = null;    

        public MaterialsPage()
        {
            InitializeComponent();
            GetMaterials();
        }

        private void GetMaterials()
        {
            IndustryContext.UseDatabase(db =>
            {
                material[] materials = db.materials.ToArray();

                MaterialsList = null;
                MaterialsList.ItemsSource = materials;
            });
        }

        private void EmployeesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            material user = listBox.SelectedItem as material;
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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            material material = MaterialsList.SelectedItem as material;
            if (material == null)
            {
                App.ShowMessage("Выберите материал");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                material existMaterial = db.materials.FirstOrDefault(m => m.id == Material.id);
                db.materials.Remove(existMaterial);
                db.SaveChanges();
            });

            App.ShowMessage("Материал удалён");
            GetMaterials();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            material material = MaterialsList.SelectedItem as material;
            if (material == null)
            {
                App.ShowMessage("Выберите материал");
                return;
            }

            MaterialEditor editor = new MaterialEditor(material);
            editor.ShowDialog();

            GetMaterials();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MaterialEditor editor = new MaterialEditor();
            editor.ShowDialog();

            GetMaterials();
        }
    }
}

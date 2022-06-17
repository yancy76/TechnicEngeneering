using AutoEngeneering.Models;
using AutoEngeneering.Tools;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace AutoEngeneering.Views.Windows.Editors
{
    /// <summary>
    /// Логика взаимодействия для ComponentsEditor.xaml
    /// </summary>
    public partial class ComponentEditor : Window
    {
        public component Component = null;

        public ComponentEditor(component component = null)
        {
            InitializeComponent();

            IndustryContext.UseDatabase(db =>
            {
                technic_types[] types = db.technic_types.ToArray();
                material[] materials = db.materials.ToArray();

                TechnicBox.ItemsSource = types;
                MaterialBox.ItemsSource = materials;
            }); 

            if (component != null)
            {
                TitleBox.Text = component.title;
                VolumeBox.Text = component.volume.ToString();
                MaterialBox.SelectedValue = component.id_material;
                TechnicBox.SelectedValue = component.id_technic;

                Component = component;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

            String title = TitleBox.Text;
            if (String.IsNullOrWhiteSpace(title))
            {
                App.ShowMessage("Введите название детали");
                return;
            }

            String volume = VolumeBox.Text;
            if (String.IsNullOrWhiteSpace(volume))
            {
                App.ShowMessage("Введите объём детали");
                return;
            }

            material material = MaterialBox.SelectedItem as material;
            if (material == null)
            {
                App.ShowMessage("Выберите материал");
                return;
            }

            technic_types technic = TechnicBox.SelectedItem as technic_types;
            if (technic == null)
            {
                App.ShowMessage("Выберите технику");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                if (Component == null)
                {
                    component component = new component();
                    component.title = title;
                    component.volume = Convert.ToDouble(volume);
                    component.id_technic = technic.id;
                    component.id_material = material.id;

                    db.components.Add(component);
                }
                else
                {
                    component component = db.components.FirstOrDefault(c => c.id == Component.id);
                    component.title = title;
                    component.volume = Convert.ToDouble(volume);
                    component.id_technic = technic.id;
                    component.id_material = material.id;

                    db.Entry(component).State = EntityState.Modified;
                }

                db.SaveChanges();
            });
        }
    }
}

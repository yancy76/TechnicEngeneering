using AutoEngeneering.Models;
using AutoEngeneering.Tools;
using System;
using System.Linq;
using System.Windows;

namespace AutoEngeneering.Views.Windows.Editors
{
    /// <summary>
    /// Логика взаимодействия для MaterialEditor.xaml
    /// </summary>
    public partial class MaterialEditor : Window
    {
        public material Material = null;

        public MaterialEditor(material material = null)
        {
            InitializeComponent();
            if (material != null)
            {
                TitleBox.Text = material.title;
                PriceBox.Text = material.pricePerCent.ToString();
                Material = material;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            String title = TitleBox.Text;
            if (String.IsNullOrWhiteSpace(title))
            {
                App.ShowMessage("Введите название");
                return;
            }

            String price = PriceBox.Text;
            if (String.IsNullOrWhiteSpace(price))
            {
                App.ShowMessage("Введите цену за сантиметр");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                if (Material == null)
                {
                    material material = new material();
                    material.title = title;
                    material.pricePerCent = Convert.ToInt32(price);

                    db.materials.Add(material);
                }
                else
                {
                    material material = db.materials.FirstOrDefault(m => m.id == Material.id);
                    material.title = title;
                    material.pricePerCent = Convert.ToInt32(price);

                    db.Entry(material).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            });
        }
    }
}

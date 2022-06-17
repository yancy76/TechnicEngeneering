using AutoEngeneering.Models;
using AutoEngeneering.Tools;
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

namespace AutoEngeneering.Views.Windows.Editors
{
    /// <summary>
    /// Логика взаимодействия для TechnicTypesEditor.xaml
    /// </summary>
    public partial class TechnicTypesEditor : Window
    {
        public technic_types Type = null;

        public TechnicTypesEditor(technic_types type = null)
        {
            InitializeComponent();
            if (type != null)
            {
                TitleBox.Text = type.name;
                Type = type;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            String title = TitleBox.Text;
            if (String.IsNullOrWhiteSpace(title))
            {
                App.ShowMessage("Введите название техники");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                if (Type == null)
                {
                    technic_types type = new technic_types();
                    type.name = title;

                    db.technic_types.Add(type);
                }
                else
                {
                    technic_types type = db.technic_types.FirstOrDefault(t => t.id == Type.id);
                    type.name = title;

                    db.Entry(type).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            });

        }
    }
}

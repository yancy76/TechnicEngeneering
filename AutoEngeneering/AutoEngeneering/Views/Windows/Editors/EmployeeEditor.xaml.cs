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
    /// Логика взаимодействия для EmployeeEditor.xaml
    /// </summary>
    public partial class EmployeeEditor : Window
    {
        public employee Employee = null;

        public EmployeeEditor(employee employee = null)
        {
            InitializeComponent();

            if (employee != null)
            {
                FirstNameBox.Text = employee.firstName;
                LastName.Text = employee.lastName;
                MiddleName.Text = employee.middleName;

                Employee = employee;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            String firstName = FirstNameBox.Text;
            if (String.IsNullOrWhiteSpace(firstName))
            {
                App.ShowMessage("Введите имя");
                return;
            }

            String lastName = LastName.Text;
            if (String.IsNullOrWhiteSpace(lastName))
            {
                App.ShowMessage("Введите фамилию");
                return;
            }

            String middleName = MiddleName.Text;
            if (String.IsNullOrWhiteSpace(middleName))
            {
                App.ShowMessage("Введите отчество");
                return;
            }

            ComboBoxItem item = PositionBox.SelectedItem as ComboBoxItem;
            if (item == null)
            {
                App.ShowMessage("Выберите должность");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                if (Employee == null)
                {
                    employee employee = new employee();
                    employee.firstName = firstName;
                    employee.lastName = lastName;
                    employee.middleName = middleName;
                    employee.position = Convert.ToInt32(item.Tag);

                    db.employees.Add(employee); 
                }
                else
                {
                    employee employee = db.employees.First(emp => emp.id == Employee.id);
                    employee.firstName = firstName;
                    employee.lastName = lastName;
                    employee.middleName = middleName;
                    employee.position = Convert.ToInt32(item.Tag);

                    db.Entry(employee).State = EntityState.Modified;
                }

                db.SaveChanges();
            });
        }
    }
}

using AutoEngeneering.Models;
using AutoEngeneering.Tools;
using AutoEngeneering.Views.Windows.Editors;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoEngeneering.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            GetEmployees();
        }

        private void GetEmployees()
        {
            IndustryContext.UseDatabase(db =>
            {
                employee[] employees = db.employees.ToArray();
                EmployeesList.ItemsSource = null;
                EmployeesList.ItemsSource = employees;
            });
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            editor.ShowDialog();

            GetEmployees();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            employee employee = EmployeesList.SelectedItem as employee;
            if (employee == null)
            {
                App.ShowMessage("Выберите сотрудника");
                return;
            }

            EmployeeEditor editor = new EmployeeEditor(employee);
            editor.ShowDialog();

            GetEmployees();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            employee employee = EmployeesList.SelectedItem as employee;
            if (employee == null)
            {
                App.ShowMessage("Выберите сотрудника");
                return;
            }

            IndustryContext.UseDatabase(db =>
            {
                employee existEmployee = db.employees.FirstOrDefault(emp => emp.id == employee.id);
                db.employees.Remove(existEmployee);

                db.SaveChanges();
            });

            App.ShowMessage("Сотрудник удалён");
            GetEmployees();
        }

        private void EmployeesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            employee employee = listBox.SelectedItem as employee;
            if (employee == null)
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

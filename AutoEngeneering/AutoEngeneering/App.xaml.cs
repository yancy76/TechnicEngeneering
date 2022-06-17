using AutoEngeneering.Models;
using AutoEngeneering.Views.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AutoEngeneering
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static user CurrentUser;
        public static BaseWindow CurrentWindow; 

        public static MessageBoxResult ShowMessage(String message, String title = "Сообщение", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.Asterisk)
        {
            return MessageBox.Show(message, title, button, image);
        }
    }
}

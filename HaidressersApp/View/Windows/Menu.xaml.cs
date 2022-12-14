using HaidressersApp.View.Pages;
using HaidressersApp.View.Windows;
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

namespace HaidressersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void RecordBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrm.Navigate(new Record());
        }

        private void ServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrm.Navigate(new Services());
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrm.Navigate(new Employee());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrm.Navigate(new Home());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("У вас ноль уведомлений!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

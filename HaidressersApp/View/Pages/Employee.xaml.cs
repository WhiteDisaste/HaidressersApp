using HaidressersApp.AppData;
using HaidressersApp.Model;
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

namespace HaidressersApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : Page
    {
        
        public Employee()
        {
            InitializeComponent();
            
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txtActivityName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            //if (txtActivityName.SelectedIndex == 0)
            //   CustomersList.ItemsSource = select.FindAll(x => x.Role.Title == "admin").ToList();
            //if (txtActivityName.SelectedIndex == 1)
            //    CustomersList.ItemsSource = select.FindAll(x => x.Role.Title == "barber").ToList();
            //if (txtActivityName.SelectedIndex == 2)
            //    CustomersList.ItemsSource = select.FindAll(x => x.Role.Title == "client").ToList();
        }
    }
}

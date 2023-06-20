using HaidressersApp.AppData;
using HaidressersApp.Model;
using HaidressersApp.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
    /// Логика взаимодействия для Record.xaml
    /// </summary>
    public partial class Record : Page
    {     
        public Record()
        {
            InitializeComponent();
            CustomersList.ItemsSource = ConnectClass.entities.Users.ToList();           
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CustomersList.ItemsSource =
        } 

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text.Length == 0) 
            {
                SearchTextTextBlock.Visibility = Visibility.Visible; 
                CustomersList.ItemsSource = ConnectClass.entities.Users.ToList();
            }
            else
            {               
                SearchTextTextBlock.Visibility = Visibility.Hidden; 
                GetSearch(); 
            }
        }
        private void GetSearch() 
        {
            var Sweep = ConnectClass.entities.Users.ToList(); 

            Sweep = Sweep.Where(Cookie => 
            Cookie.DateBirth.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()) || 
            Cookie.Name.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())).ToList(); 

            CustomersList.ItemsSource = Sweep.OrderBy(Cookie => Cookie.Id).ToList(); 
        }
    }
}

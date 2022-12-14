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
            CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();           
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRecord record = new AddRecord();
            record.Show();
        }
             
        private void Delettn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
            {
                var record = CustomersList.SelectedItem as Model.Record; 
                ConnectClass.entities.Record.Remove(record); 
                ConnectClass.entities.SaveChanges(); 
                CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();               
            }
        }
      
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Model.Record record = (Model.Record) CustomersList.SelectedItem;
            UpdateRecord update = new UpdateRecord(record);
            update.Show();  
            
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text.Length == 0) 
            {
                SearchTextTextBlock.Visibility = Visibility.Visible; 
                CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();
            }
            else
            {               
                SearchTextTextBlock.Visibility = Visibility.Hidden; 
                GetSearch(); 
            }
        }
        private void GetSearch() 
        {
            var Sweep = ConnectClass.entities.Record.ToList(); 

            Sweep = Sweep.Where(Cookie => 
            Cookie.Date.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()) || 
            Cookie.Surname.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())).ToList(); 

            CustomersList.ItemsSource = Sweep.OrderBy(Cookie => Cookie.Id).ToList(); 
        }
    }
}

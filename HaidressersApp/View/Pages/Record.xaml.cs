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
    /// Логика взаимодействия для Record.xaml
    /// </summary>
    public partial class Record : Page
    {
        public Record()
        {
            InitializeComponent();
            CustomersList.ItemsSource = ConnectClass.entities.Record.ToList();
            CustomersList.ItemsSource = ConnectClass.entities.User.ToList();
            CustomersList.ItemsSource = ConnectClass.entities.Uchet.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CustomersList.ItemsSource = ConnectClass.entities.Uchet.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uchet journal = (Uchet)CustomersList.SelectedItem;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRecord record = new AddRecord();
            record.Show();
        }

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetSearch();
        }
        private void GetSearch() 
        {
            var select = ConnectClass.entities.Record.ToList();

            select = select.Where(Sel =>
            Sel.Date.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();
            CustomersList.ItemsSource = select.OrderBy(Cookie => Cookie.IdUser).ToList(); 
        }

        private void Delettn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using HaidressersApp.AppData;
using HaidressersApp.Model;
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
    }
}

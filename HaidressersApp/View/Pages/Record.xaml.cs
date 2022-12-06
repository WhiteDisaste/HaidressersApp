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
        public List<RecordClass> record = new List<RecordClass>();
        public Record()
        {
            InitializeComponent();
            record.Add(new RecordClass("2022/10/11", "Каримова", "Милена", "admin"));
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
             
        private void Delettn_Click(object sender, RoutedEventArgs e)
        {

        }
        public void LoadUser(List<User> _user)
        {
            CustomersList.Items.Clear(); // очищаем лист с элементами

            for (int i = 0; i < _user.Count; i++) // перебираем элементы
            {
                CustomersList.Items.Add(_user[i]); // добавляем элементы в ListBox
            }
        }
        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            //newUsers = user;

            //if (genderFilter.SelectedIndex == 0)
            //    newUsers = user.FindAll(x => x.gender == "M");
            //else
            //    newUsers = user.FindAll(x => x.gender == "F");
            //newUsers = newUsers.FindAll(x => x.name.Contains(nameFilter.Text));
            //LoadUser(newUsers);

        }
        
    }
}

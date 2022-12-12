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
        List<User> user = new List<User>();
        public Employee()
        {
            InitializeComponent();
            CustomersList.DataContext = ConnectClass.entities.User.ToList();
            LoadUser(user);
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //ustomersList.DataContext = ConnectClass.entities.User.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        private void ActiveFilter_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();
            users = user;
            if (txtActivityName.SelectedIndex == 0)
            {
                users = user.FindAll(x => x.Role.Title == "admin");
            }
            if (txtActivityName.SelectedIndex == 1)
            {
                users = user.FindAll(x => x.Role.Title == "barber");
            }
            else
                users = user.FindAll(x => x.Role.Title == "client");
            LoadUser(users);
        }
    }
}

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
using System.Windows.Shapes;

namespace HaidressersApp.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                mes += "Введите имя пользователя\n";

            if (string.IsNullOrWhiteSpace(txtUsersurname.Text))
                mes += "Введите фамилия пользователя\n";

            if (string.IsNullOrWhiteSpace(dapicCalendar.Text))
                mes += "Введите дату рождения пользователя\n";

            if (string.IsNullOrWhiteSpace(txtUserTelephone.Text))
                mes += "Введите телефон пользователя\n";          
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            User user = new User()
            {
                Name = txtUsername.Text,
                Surname = txtUsersurname.Text,
                Telephone = txtUserTelephone.Text,
                DateBirth = (DateTime)dapicCalendar.SelectedDate
            };
            ConnectClass.entities.User.Add(user);
            ConnectClass.entities.SaveChanges();
            MessageBox.Show("запись добавлена");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

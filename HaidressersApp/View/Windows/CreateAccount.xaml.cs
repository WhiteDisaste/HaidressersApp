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
    /// Логика взаимодействия для CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                mes += "Введите имя пользователя\n";
            if (string.IsNullOrWhiteSpace(txtUsersurname.Text))
                mes += "Введите фамилию пользователя\n";
            if (string.IsNullOrWhiteSpace(txtUserTelephone.Text))
                mes += "Введите телефон пользователя\n";
            if (string.IsNullOrWhiteSpace(txtUserLogin.Text))
                mes += "Введите логин пользователя\n";
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
                mes += "Введите пароль пользователя\n";
            if (string.IsNullOrWhiteSpace(dapicCalendar.Text))
                mes += "Введите дату рождения\n";
            if (txtPassword.Password != txtPassword2.Password)
                mes += "Пароли не совпадают";
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
                Login = txtUserLogin.Text,
                Password = txtPassword.Password,
                DateBirth = Convert.ToDateTime(dapicCalendar.Text)
            };
            ConnectClass.entities.User.Add(user);
            ConnectClass.entities.SaveChanges();
            MessageBox.Show("запись добавлена");
            Menu menu = new Menu();
            menu.Show();
            Close();
        }
    }
}

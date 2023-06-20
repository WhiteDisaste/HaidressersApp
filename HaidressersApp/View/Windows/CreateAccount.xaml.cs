using HaidressersApp.AppData;
using HaidressersApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            if (string.IsNullOrWhiteSpace(txtUserLogin.Text))
                mes += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
                mes += "Введите пароль\n";
            if (string.IsNullOrWhiteSpace(txtUser.Text))
                mes += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
                mes += "Введите телефон\n";
            if (txtPassword.Password != txtPassword2.Password)
                mes += "Пароли не совпадают\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Users accounting = new Users()
            {
                Name = txtUser.Text,
                Login = txtUserLogin.Text,
                Password = txtPassword.Password,
                Telephone = txtTelephone.Text
            };
            ConnectClass.entities.Users.Add(accounting);
            ConnectClass.entities.SaveChanges();
            MessageBox.Show("пользователь добавлен");
            txtPassword.Password = "";
            txtUser.Text = "";
            txtTelephone.Text = "";
            txtUserLogin.Text = "";

            Menu menu = new Menu();
            menu.Show();
            Close();
        }
    }
}

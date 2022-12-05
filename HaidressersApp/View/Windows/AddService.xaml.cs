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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                mes += "Введите название услуги\n";

            if (string.IsNullOrWhiteSpace(txtUsersurname.Text))
                mes += "Введите цену услуги\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Service user = new Service()
            {
                Name = txtUsername.Text,
                Price = Convert.ToDecimal(txtUsersurname.Text)
            };
            ConnectClass.entities.Service.Add(user);
            ConnectClass.entities.SaveChanges();
            MessageBox.Show("запись добавлена");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
    
}

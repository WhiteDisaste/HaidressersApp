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
    /// Логика взаимодействия для AddRecord.xaml
    /// </summary>
    public partial class AddRecord : Window
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                mes += "Выберите пользователя\n";           
            if (string.IsNullOrWhiteSpace(dapicCalendar.Text))
                mes += "Введите дату посещения\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Record record = new Record()
            {
                Name = txtUsername.Text,
                Surname = txtUsersurname.Text,
                Date = (DateTime)dapicCalendar.SelectedDate
            };
            ConnectClass.entities.Record.Add(record);
            ConnectClass.entities.SaveChanges();
            MessageBox.Show("запись добавлена");
        }
    }
}


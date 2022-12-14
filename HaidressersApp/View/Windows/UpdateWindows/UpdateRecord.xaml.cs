using HaidressersApp.AppData;
using HaidressersApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для UpdateRecord.xaml
    /// </summary>
    public partial class UpdateRecord : Window
    {
        public UpdateRecord(Record record)
        {
            InitializeComponent();
            ConnectClass.entities = new Model.HairdressersAppDEminEntities2();
            txtUsername.DataContext = record.Name;
            txtUsersurname.DataContext = record.Surname;
            dapicCalendar.DataContext = record.Date;
            
        }

        private void LogimBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Record record = new Record()
            {
                Name = txtUsername.Text,
                Surname = txtUsersurname.Text,
                Date = Convert.ToDateTime(dapicCalendar.Text)             
            };
            
            try
            {
                if (record != null)
                {
                    ConnectClass.entities.Record.AddOrUpdate(record);
                }
                else
                {
                    ConnectClass.entities.Record.Add(record);
                }
                ConnectClass.entities.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Ошибка");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

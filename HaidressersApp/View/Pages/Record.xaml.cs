using HaidressersApp.AppData;
using HaidressersApp.Model;
using HaidressersApp.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
            record.Add(new RecordClass("2022/10/11", "Демин", "Данила", "admin"));
            record.Add(new RecordClass("2022/10/11", "Карпова", "Милена", "barber"));
            record.Add(new RecordClass("2022/10/11", "Каримова", "Милена", "barber"));
            record.Add(new RecordClass("2022/10/11", "Маслова", "Милена", "client"));
            record.Add(new RecordClass("2022/10/11", "Макаркин", "Егор", "client"));
            LoadUser(record);
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           // CustomersList.ItemsSource = ConnectClass.entities.Uchet.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Uchet journal = (Uchet)CustomersList.SelectedItem;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRecord record = new AddRecord();
            record.Show();
        }
             
        private void Delettn_Click(object sender, RoutedEventArgs e)
        {
            // Removes the first item in the list.
            CustomersList.Items.RemoveAt(0);
            MessageBox.Show("Запись удалена " + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void LoadUser(List<RecordClass> _record)
        {
            CustomersList.Items.Clear(); // очищаем лист с элементами

            for (int i = 0; i < _record.Count; i++) // перебираем элементы
            {
                CustomersList.Items.Add(_record[i]); // добавляем элементы в ListBox
            }
        }
        

        private void ActiveFilter_Click(object sender, RoutedEventArgs e)
        {
            List<RecordClass> newRecord = new List<RecordClass>();
            newRecord = record;

            if (txtActivityName.SelectedIndex == 0)
                newRecord = record.FindAll(x => x.Title == "admin");
            else
                newRecord = record.FindAll(x => x.Title == "client");
            if (txtActivityName.SelectedIndex == 2)
                newRecord = record.FindAll(x => x.Title == "barber");

            newRecord = newRecord.FindAll(x => x.Title.Contains(SearchTextBox.Text));

            LoadUser(newRecord);
        }
    }
}

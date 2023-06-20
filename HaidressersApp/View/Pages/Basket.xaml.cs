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
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        public Basket()
        {
            InitializeComponent();          
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            СhoosingOrder сhoosing = new СhoosingOrder();
            сhoosing.Show();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Получение текущего значения счетчика из TextBox
            int currentValue = int.Parse(txtselect.Text);

            // Увеличение значения счетчика на единицу
            int incrementedValue = currentValue + 1;

            // Обновление значения счетчика в TextBox
            txtselect.Text = incrementedValue.ToString();


            // Получение текущего значения счетчика из TextBox
            int current = int.Parse(txtsumma.Text);

            // Увеличение значения счетчика на единицу
            int incremented = current + 450;

            // Обновление значения счетчика в TextBox
            txtsumma.Text = incremented.ToString();


            // Получение текущего значения счетчика из TextBox
            int curren = int.Parse(txtammount.Text);

            // Увеличение значения счетчика на единицу
            int incremente= curren + 1;

            // Обновление значения счетчика в TextBox
            txtammount.Text = incremente.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получение текущего значения счетчика из TextBox
            int currentValue = int.Parse(txtselect.Text);

            // Увеличение значения счетчика на единицу
            int incrementedValue = currentValue - 1;

            // Обновление значения счетчика в TextBox
            txtselect.Text = incrementedValue.ToString();


            // Получение текущего значения счетчика из TextBox
            int current = int.Parse(txtsumma.Text);

            // Увеличение значения счетчика на единицу
            int incremented = current - 450;

            // Обновление значения счетчика в TextBox
            txtsumma.Text = incremented.ToString();


            // Получение текущего значения счетчика из TextBox
            int curren = int.Parse(txtammount.Text);

            // Увеличение значения счетчика на единицу
            int incremente = curren - 1;

            // Обновление значения счетчика в TextBox
            txtammount.Text = incremente.ToString();
        }
    }
}

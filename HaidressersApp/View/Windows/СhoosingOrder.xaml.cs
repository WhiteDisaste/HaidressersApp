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
    /// Логика взаимодействия для СhoosingOrder.xaml
    /// </summary>
    public partial class СhoosingOrder : Window
    {
        public СhoosingOrder()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш заказ оформлен вы выбрали доставку на дои" + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш заказ оформлен вы выбрали самовывоз"  + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}

using HaidressersApp.AppData;
using MaterialDesignThemes.Wpf;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public bool IsDarkTheme { get; set; }

        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        private void ThemeToggle_Click(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }



        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void LogimBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = ConnectClass.entities.User.Where(x => x.Login == txtUsername.Text && x.Password == txtPassword.Password).FirstOrDefault();
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет", "Mistake", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1:
                            MessageBox.Show("Hello, Administrator " + userObj.Name + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                        case 2:
                            MessageBox.Show("Hello, Barber " + userObj.Name + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                        case 3:
                            MessageBox.Show("Hello, Client " + userObj.Name + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                        default:
                            MessageBox.Show("No data detected!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Mistake" + Ex.Message.ToString() + "Critical operation of the application", "Notification", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            Menu au = new Menu();
            au.Show();
            Close();

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SignupBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount account = new CreateAccount();
            account.Show();
            Close();
        }
    }
}

﻿using HaidressersApp.AppData;
using HaidressersApp.Model;
using HaidressersApp.View.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Page
    {
        public Services()
        {
            InitializeComponent();
            //CustomersList.ItemsSource = ConnectClass.entities.Service.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //CustomersList.ItemsSource = ConnectClass.entities.Service.ToList();
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Service journal = (Service)CustomersList.SelectedItem;
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomersList.Items.SortDescriptions.Add(
        new SortDescription("Content", ListSortDirection.Descending));
        }
    }
}

﻿using System;
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

namespace Ch08Ex01
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!";
            Button newButton = new Button();
            newButton.Content = "New Button!";
            newButton.Margin = new Thickness(10, 10, 100, 100);
            newButton.Click += NewButton_Click;
            ((Grid)((Button)sender).Parent).Children.Add(newButton);
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!";
        }
    }
}

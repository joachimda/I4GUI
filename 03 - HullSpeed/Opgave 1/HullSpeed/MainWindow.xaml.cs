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

namespace HullSpeed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sailboat s = new Sailboat();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            s.Length = double.Parse(textBoxLength.Text);
            textBoxCalculatedSpeed.Text = s.Hullspeed().ToString();

        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            s.Name = textBoxLength.Text;
        }
    }
}

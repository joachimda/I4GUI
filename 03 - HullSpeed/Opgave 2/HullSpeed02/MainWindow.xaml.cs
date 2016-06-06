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
using HullSpeed;

namespace HullSpeed02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Sailboat sailboat = new Sailboat();


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            sailboat.Length = double.Parse(LenghtBox.Text);
            CalculatedSpeedBox.Text = CalculatedSpeedBox.ToString();
            sailboat.Name = NameBox.ToString();
        }
    }
}

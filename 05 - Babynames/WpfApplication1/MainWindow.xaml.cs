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

namespace WpfApplication1
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

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {

            //Read each line into own string
            string[] lineArray = System.IO.File.ReadAllLines("05-babynames.txt");

            List<string> NamesAndRanksList = new List<string>();

            for (int i = 0; i < lineArray.Length; i++)
            {
                NamesAndRanksList.Add(lineArray[i]);
            }

            //Generate decades
            List<string> decades = new List<string>();

            for (int i = 1900; i <= 2000; i += 10)
            {
                decades.Add(i.ToString());
            }

            //Show the decades in listbox
            DecadesListBox.ItemsSource = decades;

            foreach (string item in NamesAndRanksList)
            {
                BabyName n = new BabyName(item);
                
            }

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

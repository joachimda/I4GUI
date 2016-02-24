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
        private readonly List<BabyName> _babyNameCollection = new List<BabyName>();
        private readonly List<BabyName> _top20Babies = new List<BabyName>();
        private readonly List<string> _top10BabyNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {

#region Load all the BabyNames

            //Read each line into own string
            var lineArray = System.IO.File.ReadAllLines("05-babynames.txt");

            var namesAndRanksList = new List<string>();


            //Create All babyname objects
            foreach (var t in lineArray)
            {
                _babyNameCollection.Add(new BabyName(t));
                namesAndRanksList.Add(t);
            }

#endregion

#region Generate decades and input to ListBox
            //Generate decades
            var decades = new List<string>();

            for (var i = 1900; i <= 2000; i += 10)
            {
                decades.Add(i.ToString());
            }

            //Show the decades in listbox
            DecadesListBox.ItemsSource = decades;
#endregion

        }

        public void DetermineTopBabyNames(int decade)
        {
            //Variables for iterating the top 20 Babynames
            var firstIndex = 0;
            var secondIndex = 1;
            
            //Clear previous tops
            _top10BabyNames.Clear();
            _top20Babies.Clear();

            foreach (
                var babyName in
                    _babyNameCollection.Where(babyName => babyName.Rank(decade) < 11 && babyName.Rank(decade) > 0))
            {
                _top20Babies.Add(babyName);
            }

            _top20Babies.Sort((a, b) => a.Rank(decade).CompareTo(b.Rank(decade)));
            
            for (var i = 1; i < 11; i++)
            {
                _top10BabyNames.Add(i + " ");
            }
            
            for (var i = 0; i < 10; i++)
            {
                _top10BabyNames[i] += (_top20Babies[i+firstIndex++].Name + " and " + _top20Babies[i+secondIndex++].Name);
            }

            TopTenListBox.ItemsSource = _top10BabyNames;
            TopTenListBox.Items.Refresh();
        }

        private void DecadesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetermineTopBabyNames((DecadesListBox.SelectedIndex) * 10 + 1900);
        }
    }
}

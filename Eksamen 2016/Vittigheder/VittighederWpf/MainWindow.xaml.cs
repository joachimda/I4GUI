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

namespace VittighederWpf
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


        private void LbJokes_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = (ListBox)sender;

            Joke selectedItem = (Joke)selected.SelectedItem;
            String author = selectedItem.Source;
            string setup = selectedItem.Setup;
            List<string> tags = selectedItem.Tags;
            string punchline = selectedItem.Punchline;

            if (selectedItem.IsRiddle)
            {
                riddleDlg dialog = new riddleDlg(author, setup,punchline,tags);
                dialog.Owner = this;
                dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dialog.ShowDialog(); //Modal dialog
            }
            else
            {
                jokeDlg dialog = new jokeDlg(author, setup, tags);
                dialog.Owner = this;
                dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dialog.ShowDialog(); //Modal dialog
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string tag = tbSearch.Text;
            Jokes jokes = new Jokes();

            foreach (var joke in JokeContext)
            {
                if (joke.ContainsTag(tag))
                {
                    jokes.Add(joke);
                }
            }


            SearchView sw = new SearchView(jokes);

            sw.Owner = this;
            sw.WindowStartupLocation= WindowStartupLocation.CenterOwner;
            sw.Show();

        }
    }
}

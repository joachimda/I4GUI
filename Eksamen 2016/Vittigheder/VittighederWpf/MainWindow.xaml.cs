using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main window - Init and generates dummy data
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            JokeContext.GenerateDummyData(3);
        }

        /// <summary>
        /// Eventhandler for the Listbox with jokes.
        /// Opens RiddleDialog if Joke is a riddle and a JokeDialog if not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbJokes_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = (ListBox)sender;

            var selectedItem = (Joke)selected.SelectedItem;
            var author = selectedItem.Source;
            var setup = selectedItem.Setup;
            List<string> tags = selectedItem.Tags;
            var punchline = selectedItem.Punchline;

            if (selectedItem.IsRiddle)
            {
                var dialog = new riddleDlg(author, setup, punchline, tags)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dialog.ShowDialog(); //Modal dialog
            }
            else
            {
                var dialog = new jokeDlg(author, setup, tags)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dialog.ShowDialog(); //Modal dialog
            }
        }

        /// <summary>
        /// Eventhandler for Search button - Calls IsTagFound on Joke object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var tag = tbSearch.Text;

            var jokes = await Task.Run(() =>
            {
                var tmpJokes = new Jokes();

                foreach (var joke in JokeContext.Where(joke => joke.IsTagFound(tag)))
                {
                    tmpJokes.Add(joke);
                }

                return tmpJokes;
            });

            var sw = new SearchView(jokes)
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            sw.Show();

        }


        /// <summary>
        /// Eventhandler for Listbox with jokes.
        /// Enables rigth-clicking on a list item to delete it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbJokes_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var result = MessageBox.Show("Do you wish to delete this item?", "Delete joke", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                JokeContext.Remove((Joke)lbJokes.SelectedItem);
            }
        }
    }
}

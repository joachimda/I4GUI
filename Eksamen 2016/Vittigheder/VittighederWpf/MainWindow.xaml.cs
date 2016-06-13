using System;
using System.Collections.Generic;
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

            Joke selectedItem = (Joke)selected.SelectedItem;
            String author = selectedItem.Source;
            string setup = selectedItem.Setup;
            List<string> tags = selectedItem.Tags;
            string punchline = selectedItem.Punchline;

            if (selectedItem.IsRiddle)
            {
                riddleDlg dialog = new riddleDlg(author, setup, punchline, tags);
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

        /// <summary>
        /// Eventhandler for Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string tag = tbSearch.Text;

            Jokes jokes = await Task.Run(() =>
            {
                Jokes tmpJokes = new Jokes();

                foreach (var joke in JokeContext)
                {
                    if (joke.ContainsTag(tag))
                    {
                        tmpJokes.Add(joke);
                    }
                }

                return tmpJokes;
            });

            /*Run in main thread*/
            //Jokes jokes = new Jokes();

            //foreach (var joke in JokeContext)
            //{
            //    if (joke.ContainsTag(tag))
            //    {
            //        jokes.Add(joke);
            //    }
            //}

            SearchView sw = new SearchView(jokes);

            sw.Owner = this;
            sw.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            sw.Show();

        }

        private void LbJokes_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you wish to delete this item?", "Delete joke", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                JokeContext.Remove((Joke)lbJokes.SelectedItem);
            }
        }
    }
}

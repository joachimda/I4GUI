using System.Collections.Generic;
using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for jokeDlg.xaml
    /// </summary>
    public partial class JokeDialog : Window
    {
        public JokeDialog(string author, string setup, List<string> tags )
        {
            InitializeComponent();
            tBAuthor.Text = author;
            tBJoke.Text = setup;
            lsbxTags.ItemsSource = tags;
        }
    }
}


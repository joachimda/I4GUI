using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for jokeDlg.xaml
    /// </summary>
    public partial class JokeDialog : Window
    {
        public JokeDialog(string author, string setup, List<string> tags, DateTime time )
        {
            InitializeComponent();
            tBAuthor.Text = author;
            tBJoke.Text = setup;
            tBDate.Text = time.ToString(CultureInfo.InvariantCulture);
            lsbxTags.ItemsSource = tags;
        }
    }
}


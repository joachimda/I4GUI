using System.Collections.Generic;
using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for riddleDlg.xaml
    /// </summary>
    public partial class riddleDlg : Window
    {
        public riddleDlg(string author, string setup, string punchline, List<string> tags)
        {
            InitializeComponent();
            InitializeComponent();
            tBAuthor.Text = author;
            tBJoke.Text = setup;
            tBPunchline.Text = punchline;

            lsbxTags.ItemsSource = tags;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for riddleDlg.xaml
    /// </summary>
    public partial class RiddleDialog : Window
    {
        public RiddleDialog(string author, string setup, string punchline, List<string> tags, DateTime time)
        {
            InitializeComponent();
            InitializeComponent();
            tBAuthor.Text = author;
            tBDate.Text = time.ToString(CultureInfo.InvariantCulture);
            tBJoke.Text = setup;
            tBPunchline.Text = punchline;

            lsbxTags.ItemsSource = tags;
        }
    }
}

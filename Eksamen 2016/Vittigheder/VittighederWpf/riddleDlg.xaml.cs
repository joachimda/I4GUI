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
using System.Windows.Shapes;

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

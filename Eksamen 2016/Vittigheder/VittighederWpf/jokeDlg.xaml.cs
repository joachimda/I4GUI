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
    /// Interaction logic for jokeDlg.xaml
    /// </summary>
    public partial class jokeDlg : Window
    {
        public jokeDlg(string author, string setup, List<string> tags )
        {
            InitializeComponent();
            tBAuthor.Text = author;
            tBJoke.Text = setup;

            lsbxTags.ItemsSource = tags;
        }
    }
}


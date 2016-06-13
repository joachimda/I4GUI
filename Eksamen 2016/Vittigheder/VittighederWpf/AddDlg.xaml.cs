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
    /// Interaction logic for AddDlg.xaml
    /// </summary>
    public partial class AddDlg : Window
    {
        public string JokeName { get; set; }
        public string JokeSetup { get; set; }
        public string JokePunchline { get; set; }
        public string JokeTagsUnified { get; set; }
        public DateTime DateTime { get; set; }
        public AddDlg()
        {
            InitializeComponent();

        }
    }
}

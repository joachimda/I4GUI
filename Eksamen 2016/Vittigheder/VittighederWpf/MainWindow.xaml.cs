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
            //    Jokes j = new Jokes();
            var selected = (ListBox)sender;

            Joke selectedItem = (Joke)selected.SelectedItem;
            String author = selectedItem.Source;
            string setup = selectedItem.Setup;
            List<string> tags = selectedItem.Tags;
            string punchline = selectedItem.Punchline;

            if (selectedItem.IsRiddle)
            {
                riddleDlg dlg = new riddleDlg(author, setup,punchline,tags);
                dlg.Owner = this;
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dlg.ShowDialog();
            }

            else
            {
                jokeDlg dlg = new jokeDlg(author, setup, tags);

                dlg.Owner = this;
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dlg.ShowDialog(); //Modal dialog
            }
            

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
            /*
            var selected = (ListBox)sender;
            object item = selected.SelectedItem;

            //Query for name in Json file

            var q = from item in jsonJokes
                    where item.Name ==  selected
                    select item;

            if (q.Count() > 1)
            {
                throw new ArgumentException("Something went wrong")
            }

            var joke = q.First();

            if (joke.IsRiddle == false)
            {

                jokeDlg dlg = new jokeDlg(joke.Name, joke.Setup, joke.tags);

                dlg.Owner = this;
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dlg.ShowDialog(); //Modal dialog
            }

            else if (joke.IsRiddle == true)
            {
                riddleDlg = new riddleDlg(joke.Name, joke.Setup, joke.Punchline, joke.tags
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dlg.ShowDialog(); //Modal dialog
            }
            */



        }
    }
}

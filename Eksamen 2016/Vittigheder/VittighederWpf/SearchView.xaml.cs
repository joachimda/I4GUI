using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : Window
    {
        public SearchView(Jokes jokes)
        {
            InitializeComponent();
            DataContext = jokes;
        }
    }
}

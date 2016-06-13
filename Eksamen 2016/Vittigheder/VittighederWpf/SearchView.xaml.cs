using System.Windows;

namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : Window
    {

        /// <summary>
        /// Sets SearchViews DataContext
        /// </summary>
        /// <param name="jokes"> object to set the DataContext in SearchViews</param>
        public SearchView(Jokes jokes)
        {
            InitializeComponent();
            DataContext = jokes;
        }
    }
}

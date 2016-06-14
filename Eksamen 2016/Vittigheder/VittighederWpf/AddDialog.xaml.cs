using System.Windows;


namespace VittighederWpf
{
    /// <summary>
    /// Interaction logic for AddDlg.xaml
    /// </summary>
    public partial class AddDialog : Window
    {
        public string JokeName { get; set; }
        public string JokeAuthor { get; set; }
        public string JokeSetup { get; set; }
        public string JokePunchline { get; set; }
        public string JokeTagsUnified { get; set; }

        public AddDialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            JokeName = tBName.Text;
            JokeSetup = tBJoke.Text;
            JokePunchline = tBPunchline.Text;
            JokeTagsUnified = tBTags.Text;
            JokeAuthor = tBAuthor.Text;

            DialogResult = true;
        }
    }
}

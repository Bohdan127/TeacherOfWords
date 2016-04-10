using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TeacherOfWords.Modules
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddWordsPage : Page
    {
        private AutoCompleteTextBox wordOne;
        private AutoCompleteTextBox wordTwo;
        private ComboBox cbLanguages;

        public AddWordsPage()
        {
            this.InitializeComponent();

        }

        private void Ok_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AutoCompleteTextBox1_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is AutoCompleteTextBox)
                wordOne = (AutoCompleteTextBox)sender;
        }

        private void AutoCompleteTextBox2_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is AutoCompleteTextBox)
                wordTwo = (AutoCompleteTextBox)sender;
        }

        private void CbLanguages1_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox)
                cbLanguages = (ComboBox)sender;
        }
    }
}

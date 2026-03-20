using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PubNetTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clicks = 0;
        int yesClicks = 0;
        int noClicks = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (YesBox.IsChecked == true) { clicks++; yesClicks++; }
            else
            if (NoBox.IsChecked == true) { clicks++; noClicks++; }
            else MessageBox.Show("Please select an option before clicking the button.");
            ShowStats_Click();
            reset();
        }

        private void ShowStats_Click()
        {
            int percentageYes = yesClicks > 0 ? (yesClicks * 100) / clicks : 0;
            MessageBox.Show($"Total Clicks: {clicks}\nYes Clicks: {yesClicks}\nNo Clicks: {noClicks}\n Percentage of Yes Clicks: {percentageYes}");
        }

        private void reset()
        {
           YesBox.IsChecked = false;
           NoBox.IsChecked = false;
        }
    }
}
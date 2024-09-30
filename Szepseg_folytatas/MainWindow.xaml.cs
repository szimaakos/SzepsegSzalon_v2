using System.Collections.ObjectModel;
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

namespace Szepseg_folytatas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Store selected service
        private RadioButton selectedService;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Starts the booking process by showing Step 1
        private void StartBooking_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Visibility = Visibility.Collapsed;
            Step1Screen.Visibility = Visibility.Visible;
        }

        // Move to the next step of the booking process
        private void NextStep_Click(object sender, RoutedEventArgs e)
        {
            // Save the selected service
            foreach (UIElement element in (Step1Screen.Children[1] as StackPanel).Children)
            {
                if (element is RadioButton service && service.IsChecked == true)
                {
                    selectedService = service;
                    break;
                }
            }

            if (selectedService != null)
            {
                MessageBox.Show($"Szolgáltatás kiválasztva: {selectedService.Content}");
                // Logic for moving to the next step can be added here
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon egy szolgáltatást.");
            }
        }

        // Go back to the previous step
        private void BackStep_Click(object sender, RoutedEventArgs e)
        {
            Step1Screen.Visibility = Visibility.Collapsed;
            HomeScreen.Visibility = Visibility.Visible;

            // Restore previously selected service
            if (selectedService != null)
            {
                selectedService.IsChecked = true;
            }
        }
    }
}
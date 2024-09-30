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
        // Store selected items
        private RadioButton selectedService;
        private RadioButton selectedEmployee;
        private string lastName, firstName, email, phone;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBooking_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Visibility = Visibility.Collapsed;
            Step1Screen.Visibility = Visibility.Visible;
        }

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
                Step1Screen.Visibility = Visibility.Collapsed;
                Step2Screen.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon egy szolgáltatást.");
            }
        }

        private void NextStep2_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement element in (Step2Screen.Children[1] as StackPanel).Children)
            {
                if (element is RadioButton employee && employee.IsChecked == true)
                {
                    selectedEmployee = employee;
                    break;
                }
            }

            if (selectedEmployee != null)
            {
                Step2Screen.Visibility = Visibility.Collapsed;
                Step3Screen.Visibility = Visibility.Visible;
                // Load available appointments for the selected employee into AppointmentGrid
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon egy dolgozót.");
            }
        }

        private void NextStep3_Click(object sender, RoutedEventArgs e)
        {
            Step3Screen.Visibility = Visibility.Collapsed;
            Step4Screen.Visibility = Visibility.Visible;
        }

        private void NextStep4_Click(object sender, RoutedEventArgs e)
        {
            lastName = LastNameTextBox.Text;
            firstName = FirstNameTextBox.Text;
            email = EmailTextBox.Text;
            phone = PhoneTextBox.Text;

            // Summary logic
            SummaryTextBlock.Text = $"Szolgáltatás: {selectedService.Content}\n" +
                                    $"Dolgozó: {selectedEmployee.Content}\n" +
                                    $"Név: {firstName} {lastName}\n" +
                                    $"Email: {email}\n" +
                                    $"Telefonszám: {phone}";

            Step4Screen.Visibility = Visibility.Collapsed;
            SummaryScreen.Visibility = Visibility.Visible;
        }

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

        private void BackToStep1_Click(object sender, RoutedEventArgs e)
        {
            Step2Screen.Visibility = Visibility.Collapsed;
            Step1Screen.Visibility = Visibility.Visible;

            // Restore previously selected service
            if (selectedService != null)
            {
                selectedService.IsChecked = true;
            }
        }

        private void BackToStep2_Click(object sender, RoutedEventArgs e)
        {
            Step3Screen.Visibility = Visibility.Collapsed;
            Step2Screen.Visibility = Visibility.Visible;

            // Restore previously selected employee
            if (selectedEmployee != null)
            {
                selectedEmployee.IsChecked = true;
            }
        }

        private void BackToStep3_Click(object sender, RoutedEventArgs e)
        {
            Step4Screen.Visibility = Visibility.Collapsed;
            Step3Screen.Visibility = Visibility.Visible;
        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            SummaryScreen.Visibility = Visibility.Collapsed;
            HomeScreen.Visibility = Visibility.Visible;
        }
    }
}
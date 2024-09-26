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
        public ObservableCollection<Ugyfel> Ugyfelek { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Ugyfelek = new ObservableCollection<Ugyfel>(LoadUgyfelekFromDatabase());
            UgyfelDataGrid.ItemsSource = Ugyfelek;
        }

        // CRUD Műveletek
        private void AddUgyfel(object sender, RoutedEventArgs e)
        {
            // Új ügyfél hozzáadása
            var ujUgyfel = new Ugyfel
            {
                UgyfelVezetekNev = "Új",
                UgyfelKeresztNev = "Ügyfél"
            };
            Ugyfelek.Add(ujUgyfel);
            SaveUgyfelToDatabase(ujUgyfel);
        }

        private void EditUgyfel(object sender, RoutedEventArgs e)
        {
            // Kijelölt ügyfél módosítása
            if (UgyfelDataGrid.SelectedItem is Ugyfel selectedUgyfel)
            {
                selectedUgyfel.UgyfelVezetekNev = "Módosított";
                UpdateUgyfelInDatabase(selectedUgyfel);
            }
        }

        private void DeleteUgyfel(object sender, RoutedEventArgs e)
        {
            // Kijelölt ügyfél törlése
            if (UgyfelDataGrid.SelectedItem is Ugyfel selectedUgyfel)
            {
                Ugyfelek.Remove(selectedUgyfel);
                DeleteUgyfelFromDatabase(selectedUgyfel.UgyfelID);
            }
        }

        // Példa a dolgozók és szolgáltatások kezelésére
        private void UgyfelekKezelese(object sender, RoutedEventArgs e)
        {
            // Ügyfelek panel megjelenítése (itt már eleve megjelenik)
        }

        private void DolgozokKezelese(object sender, RoutedEventArgs e)
        {
            // Dolgozók kezelése funkció itt fog megvalósulni
            MessageBox.Show("Dolgozók kezelése funkció...");
        }

        private void SzolgaltatasokKezelese(object sender, RoutedEventArgs e)
        {
            // Szolgáltatások kezelése funkció itt fog megvalósulni
            MessageBox.Show("Szolgáltatások kezelése funkció...");
        }

        // Adatbázis CRUD műveletekhez szükséges funkciók (példaként)
        private ObservableCollection<Ugyfel> LoadUgyfelekFromDatabase()
        {
            // Adatbázisból betöltés (példa)
            return new ObservableCollection<Ugyfel>
            {
                new Ugyfel { UgyfelID = 1, UgyfelVezetekNev = "Kiss", UgyfelKeresztNev = "János", UgyfelTelefon = "123456789", UgyfelEmail = "janos.kiss@example.com", UgyfelPontok = 100 }
            };
        }

        private void SaveUgyfelToDatabase(Ugyfel ugyfel)
        {
            // Új ügyfél mentése az adatbázisba
        }

        private void UpdateUgyfelInDatabase(Ugyfel ugyfel)
        {
            // Ügyfél módosítás mentése az adatbázisba
        }

        private void DeleteUgyfelFromDatabase(int ugyfelID)
        {
            // Ügyfél törlése az adatbázisból
        }
    }

    // Ügyfél modell osztály
    public class Ugyfel
    {
        public int UgyfelID { get; set; }
        public string UgyfelVezetekNev { get; set; }
        public string UgyfelKeresztNev { get; set; }
        public string UgyfelTelefon { get; set; }
        public string UgyfelEmail { get; set; }
        public int UgyfelPontok { get; set; }
    }
}
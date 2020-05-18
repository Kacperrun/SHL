using SHL.Pages;
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
using System.Windows.Shapes;

namespace SHL
{
    /// <summary>
    /// Interaction logic for WindowAfterLogIn.xaml
    /// </summary>
    public partial class WindowAfterLogIn : Window
    {
        public WindowAfterLogIn()
        {
            InitializeComponent();
            PageMainAfterLogIn page = new PageMainAfterLogIn();
            PageContent.Navigate(page);
        }

        private void MainMenu_Plik_StylEkranu_Jasny_Click(object sender, RoutedEventArgs e)
        {
            MainMenu_Plik_StylEkranu_Ciemny.IsChecked = false;
            MainMenu_Plik_StylEkranu_Kontrastowy.IsChecked = false;

        }

        private void MainMenu_Plik_EkranStartowy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Plik_StylEkranu_Ciemny_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void MainMenu_Plik_StylEkranu_Kontrastowy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Plik_Wyloguj_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }

        private void MainMenu_Plik_Zamknij_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Dodaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Usun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Wyszukaj_PoID_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Wyszukaj_PoAutorze_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Wyszukaj_PoTytule_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Wyszukaj_PoGatunku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_Wyszukaj_PoLokalizacji_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Ksiazki_WyswietlWszystkie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Dodaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Usun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Wyszukaj_PoID_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Wyszukaj_PoAutorze_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Wyszukaj_PoTytule_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Wyszukaj_PoGatunku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_Wyszukaj_PoLokalizacji_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Pozycje_Audiobooki_WyswietlWszystkie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Dodaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Usun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Aktualizuj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_ZmienUprawnienia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Wyszukaj_PoID_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Wyszukaj_PoNazwisku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Wyszukaj_PoLoginie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_WyswietlWszyskich_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_Uzytkownicy_Wyloguj_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void MainMenu_Klienci_Dodaj_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

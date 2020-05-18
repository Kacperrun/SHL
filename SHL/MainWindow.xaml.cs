using SHL.Services;
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


namespace SHL
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

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Login();
            }
        }

        private void Login()
        {
            if (txtLogin.Text == "admin" && txtPassword.Password == "admin1")
            {
                WindowAfterLogIn windowAfterLog = new WindowAfterLogIn();
                windowAfterLog.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło", "Nieudane logowanie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }




    }
}

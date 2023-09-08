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

namespace JhonCabrera
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (username == "usuario" && password == "123")
            {
                // Credenciales válidas, abre la nueva ventana después del inicio de sesión.
                Window1 window1 = new Window1();
                window1.Show();

                // Cierra la ventana de inicio de sesión actual.
                this.Close();
            }
            else
            {
                // Credenciales incorrectas, muestra un mensaje de error.
                txtError.Text = "Credenciales incorrectas";
            }
        }
    }
}

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

namespace JhonCabrera
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Operaciones_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Operaciones
            Salida salida = new Salida();
            salida.Show();
        }

        private void Mantenimiento_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Mantenimiento
            Conductores conductores = new Conductores();
            conductores.Show();
        }

        private void Reportes_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Reportes
            Camiones camiones = new Camiones();
            camiones.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Cierra la aplicación
            Application.Current.Shutdown();
        }
    }
}


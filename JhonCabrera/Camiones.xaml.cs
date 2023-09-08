using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Camiones.xaml
    /// </summary>
    public partial class Camiones : Window
    {
        public class Camion
        {
            public string PesoMaximo { get; set; }
            public string Placa { get; set; }
            public string PesoVacio { get; set; }
        }
        private ObservableCollection<Camion> camionesList = new ObservableCollection<Camion>();
        public Camiones()
        {
            InitializeComponent();
            lstCamiones.ItemsSource = camionesList;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            string pesoMaximo = txtPesoMaximo.Text;
            string placa = txtPlaca.Text;
            string pesoVacio = txtPesoVacio.Text;

            Camion camion = new Camion { PesoMaximo = pesoMaximo, Placa = placa, PesoVacio = pesoVacio };
            camionesList.Add(camion);

            txtPesoMaximo.Clear();
            txtPlaca.Clear();
            txtPesoVacio.Clear();
        }

    }
}

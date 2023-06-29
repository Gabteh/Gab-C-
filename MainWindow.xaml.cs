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

namespace NCalug
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double A = 0;
        public double B = 0;
        public string C;
        private void LimpBoton_Click(object sender, RoutedEventArgs e)
        {
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }

        private void SieteNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '7';
        }

        private void OchoNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '8';
        }

        private void NueveNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '9';
        }

        private void CuatroNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '4';
        }

        private void CincoNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '5';
        }

        private void SeisNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '6';
        }

        private void UnoNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '1';
        }

        private void DosNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '2';
        }

        private void TresNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '3';
        }

        private void CeroNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '0';
        }
        private void PuntoNUM_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = Pantalla.Text + '.';
        }


        /* Operaciones Matematicas */
        private void DivicionBoton_Click(object sender, RoutedEventArgs e)
        {
            try { A = Convert.ToDouble(this.Pantalla.Text); }
            catch { Pantalla.Text = "Error"; }
            C = "/";
            this.Pantalla.Clear();
            this.Pantalla.Focus();

        }

        private void MultiplicacionBoton_Click(object sender, RoutedEventArgs e)
        {
            try { A = Convert.ToDouble(this.Pantalla.Text); }
            catch { Pantalla.Text = "Error"; }
            C = "*";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }

        private void SumaBoton_Click(object sender, RoutedEventArgs e)
        {
            try { A = Convert.ToDouble(this.Pantalla.Text); }
            catch { Pantalla.Text = "Error!"; }
            C = "+";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }

        private void RestaBoton_Click(object sender, RoutedEventArgs e)
        {
            try { A = Convert.ToDouble(this.Pantalla.Text); }
            catch { Pantalla.Text = "Error!"; }
            C = "-";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }

        private void IgualNUM_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                B = Convert.ToDouble(this.Pantalla.Text);

                switch (C)
                {
                    case "+": this.Pantalla.Text = Convert.ToString(A + B); break;
                    case "-": this.Pantalla.Text = Convert.ToString(A - B); break;
                    case "*": this.Pantalla.Text = Convert.ToString(A * B); break;
                    case "/": this.Pantalla.Text = Convert.ToString(A / B); break;
                }

            }
            catch { Pantalla.Text = "Error!"; }
        }
    }
}

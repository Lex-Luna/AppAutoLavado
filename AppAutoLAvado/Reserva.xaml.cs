using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAutoLAvado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reserva : ContentPage
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void fechaPicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            fechaPicker.MinimumDate = DateTime.Now;
            lblFecha.Text = fechaPicker.Date.ToString();
        }

        private async void btnAcptar_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            float precio = 0;
            string mensaje="";
            if (chLavCompleto.IsChecked)
            {
                mensaje = "Lavado completo";
                precio += 45;
                if (chAceite.IsChecked)
                {

                    precio += 10;
                    mensaje = "Lavado completo y cambio de aceite";
                }
            }
            else if (chLavadoExpres.IsChecked)
            {
                mensaje = "Lavado express";
                precio += 25;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                    mensaje = "Lavado express y cambio de aceite";
                }
            }
            else if (chLavadoAspirado.IsChecked)
            {
                mensaje = "Lavado y aspirado";
                precio += 55;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                    mensaje = "Lavado, aspirado y cambio de aceite";
                }
            }
            else if (chAspirado.IsChecked)
            {
                precio += 10;
                mensaje = "Solo aspirado";
                if (chAceite.IsChecked)
                {
                    precio += 10;
                    mensaje = "Aspirado y cambio de aceite";
                }
            }
            string fecha = lblFecha.Text;

            await DisplayAlert("Alert", "El precio de tu compra es:"+precio, "OK");
            await Navigation.PushAsync(new Resumen(fecha,precio, mensaje));
        }

    }
}
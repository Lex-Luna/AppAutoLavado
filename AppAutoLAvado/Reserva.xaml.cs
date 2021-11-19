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
            lblFecha.Text = fechaPicker.Date.ToString();
        }

        private async void btnAcptar_Clicked(object sender, EventArgs e)
        {
            float precio = 0;
            if (chLavCompleto.IsChecked )
            {
                precio += 45;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                }
            }
            else if (chLavadoExpres.IsChecked)
            {
                precio += 25;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                }
            }
            else if (chLavadoAspirado.IsChecked)
            {
                precio += 55;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                }
            }
            else if (chAspirado.IsChecked)
            {
                precio += 10;
                if (chAceite.IsChecked)
                {
                    precio += 10;
                }
            }
            /*else if (chAceite.IsChecked)
            {
                precio += 10;
            }*/

            await DisplayAlert("Alert", "El precio de tu compra es:"+precio, "OK");
            await Navigation.PushAsync(new Resumen());
        }

    }
}
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
            await Navigation.PushAsync(new Resumen());
        }
    }
}
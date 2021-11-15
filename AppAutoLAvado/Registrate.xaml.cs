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
    public partial class Registrate : ContentPage
    {
        public Registrate()
        {
            InitializeComponent();
        }

        private async void btnAcptar_Clicked(object sender, EventArgs e)
        {
            /*try
            {

            }
            catch (Exception)
            {
                DisplayAlert("Error");
            }*/
            await Navigation.PushAsync(new Login());
        }
    }



      
    
}
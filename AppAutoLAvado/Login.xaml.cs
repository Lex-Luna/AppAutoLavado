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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            /*MainPage = new NavigationPage(new Login());*/
        }


        private async void btnRegistrate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrate());
        }
    }
}
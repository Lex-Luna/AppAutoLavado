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
        public static MasterDetailPage MasterDet { get; set; }
        public Login()
        {
            InitializeComponent();
            /*MainPage = new NavigationPage(new Login());*/
        }


        private async void btnRegistrate_Clicked(object sender, EventArgs e)
        {
            
                await Navigation.PushAsync(new Registrate());
            
        }


        private async void btnLogIn_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new MainPage());
        }
    }
}
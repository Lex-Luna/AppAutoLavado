using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAutoLAvado
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {

            InitializeComponent();
            this.Master = new Master1();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {

        }
    }
}

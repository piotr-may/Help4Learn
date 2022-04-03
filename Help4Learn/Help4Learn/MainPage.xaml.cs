using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Help4Learn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_test_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("LOL", "Udało się ziomuś", "XD");
        }
    }
}

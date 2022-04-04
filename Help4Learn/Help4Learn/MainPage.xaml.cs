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

        private async void imageSource_Clicked(object sender, EventArgs e)
        {
            string img = "https://pl.freepik.com/wektory/biznes https://pl.freepik.com/wektory/kalendarz https://www.flaticon.com/free-icons/home-button https://pl.freepik.com/wektory/biznes";
            await DisplayAlert("Linki do zdjęć w aplikacji", img, "OK");
        }
    }
}

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

        private void callendarIcon_Clicked(object sender, EventArgs e)
        {
            bool accualState = Callendar.IsVisible;
            hideAll(null, null);
            Callendar.IsVisible = accualState ? false : true;
        }

        private void examsIcon_Clicked(object sender, EventArgs e)
        {
            bool accualState = Tasks.IsVisible;
            hideAll(null, null);
            Tasks.IsVisible = accualState ? false : true;
        }

        private void activitiesIcon_Clicked(object sender, EventArgs e)
        {
            bool accualState = Activity.IsVisible;
            hideAll(null, null);
            Activity.IsVisible = accualState ? false : true;
        }

        private void hideAll(object sender, EventArgs e)
        {
            Activity.IsVisible = false;
            Tasks.IsVisible = false;
            Callendar.IsVisible = false;
        }

    }
}

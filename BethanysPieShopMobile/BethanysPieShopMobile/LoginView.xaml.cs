using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            Resources["ButtonStyle"] = DateTime.Today.DayOfWeek == DayOfWeek.Saturday
                ? Resources["RedButtonStyle"]
                : Resources["GreenButtonStyle"];
        }

        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new MainView(), this);
            await Navigation.PopAsync();
        }

        private async void RegisterButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterView());
        }
    }
}

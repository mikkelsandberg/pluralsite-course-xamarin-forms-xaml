using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();

            BirthdayDatePicker.Date = DateTime.Today;
            RegisterButton.IsEnabled = false;
        }

        private bool CheckCanRegister()
        {
            if (UsernameEntry.Text?.Length > 0 && PasswordEntry.Text?.Length > 0)
                return true;
            return false;
        }

        private void UsernameEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            RegisterButton.IsEnabled = CheckCanRegister();
        }

        private void PasswordEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            RegisterButton.IsEnabled = CheckCanRegister();
        }

        private void BirthdayDatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            if (e.NewDate == DateTime.Today)
            {
                // show warning that this is impossible
                DisplayAlert("Alert", "You can't have been born today", "Ok, I suppose");
            }
        }

        private async void RegisterButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "You have registered successfully", "Done");
        }
    }
}

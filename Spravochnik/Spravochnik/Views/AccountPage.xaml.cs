using Spravochnik.Data.User;
using System;
using Xamarin.Forms;

namespace Spravochnik.Views
{
    public partial class AccountPage : ContentPage
    {
        public static string Email = null;
        public AccountPage()
        {
            InitializeComponent();
            BindingContext = this;

            if (UserInfo.Email != null)
            {
                Email = UserInfo.Email.ToString();
                authButton.IsVisible = false;
                regButton.IsVisible = false;
                _exitButton.IsVisible = true;
                _emailLabel.Text = "Вы вошли как: " + UserInfo.Email.ToString();
            }
            else
            {
                _text.IsVisible = false;
                _emailLabel.IsVisible = false;
                _exitButton.IsVisible = false;
            }
        }
        private async void RegButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"regdetails");
        }

        private async void AuthButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"authdetails");
        }
        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage.Navigation.PopAsync();
            return false;
        }
        private void ExitButton_Clicked(object sender, EventArgs e)
        {
            UserInfo.Email = null;
            UserInfo.Message = null;
            UserInfo.Role = null;
            UserInfo.Token = null;

            var page = new AppShell();
            (Application.Current.MainPage) = page;
        }
    }
}
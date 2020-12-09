using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spravochnik
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage())
            {
                BackgroundColor = Color.White,
                BarBackgroundColor = Color.FromHex("#05438c")
            }; ;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

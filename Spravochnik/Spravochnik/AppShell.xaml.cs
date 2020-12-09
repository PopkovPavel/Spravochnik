using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Spravochnik.Views;
using Spravochnik.Data.User;

namespace Spravochnik
{
    public partial class AppShell : Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }
        public AppShell(string UserInfo)
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }
        void RegisterRoutes()
        {
            //Hide elements if User is joining without account
            if (UserInfo.Email != null)
            {
                dot3sh.IsVisible = true;
                dotish.IsVisible = false;
                dot4sh.IsVisible = true;
                dot5sh.IsVisible = true;
                dot51sh.IsVisible = true;
            }
            else
            {
                dot3sh.IsVisible = true;
                dotish.IsVisible = true;
                dot4sh.IsVisible = false;
                dot5sh.IsVisible = false;
                dot51sh.IsVisible = false;
            }
            
            routes.Add("d3details", typeof(D3DetailPage));
            routes.Add("d4details", typeof(D4DetailPage));
            routes.Add("d5details", typeof(D5DetailPage));
            routes.Add("d51details", typeof(D51DetailPage));

            Routes.Add("regdetails", typeof(RegPage));
            Routes.Add("authdetails", typeof(AuthPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }
    }
}
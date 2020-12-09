using System;
using System.Linq;
using Spravochnik.Data;
using Xamarin.Forms;

namespace Spravochnik.Views
{
    [QueryProperty("Name", "name")]
    public partial class D4DetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = Dot4Data.D4.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public D4DetailPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
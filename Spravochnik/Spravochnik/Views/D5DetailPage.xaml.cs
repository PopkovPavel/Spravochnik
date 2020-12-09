using System;
using System.Linq;
using Spravochnik.Data;
using Xamarin.Forms;

namespace Spravochnik.Views
{
    [QueryProperty("Name", "name")]
    public partial class D5DetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = Dot5Data.D5.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public D5DetailPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
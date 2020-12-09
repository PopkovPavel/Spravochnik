using System;
using System.Linq;
using Xamarin.Forms;
using Spravochnik.Data;

namespace Spravochnik.Views
{
    [QueryProperty("Name", "name")]
    public partial class D51DetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = Dot51Data.D51.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public D51DetailPage()
        {
            InitializeComponent();
        }
    }
}
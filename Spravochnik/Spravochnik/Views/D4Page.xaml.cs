using System.Linq;
using Xamarin.Forms;
using Spravochnik.Models;

namespace Spravochnik.Views
{
    public partial class D4Page : ContentPage
    {
        public D4Page()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //убирает выделение после перехода назад
            var collection = sender as CollectionView;
            if (collection.SelectedItem == null)
            {
                return;
            }
            else
            {
                string D4Name = (e.CurrentSelection.FirstOrDefault() as Fluids).Name;
                await Shell.Current.GoToAsync($"d4details?name={D4Name}");
                collection.SelectedItem = null;
            }
        }
    }
}
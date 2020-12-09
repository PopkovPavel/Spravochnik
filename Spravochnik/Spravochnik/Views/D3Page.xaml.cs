using System.Linq;
using Xamarin.Forms;
using Spravochnik.Models;

namespace Spravochnik.Views
{
    public partial class D3Page : ContentPage
    {
        public D3Page()
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
                string D3Name = (e.CurrentSelection.FirstOrDefault() as Fluids).Name;
                await Shell.Current.GoToAsync($"d3details?name={D3Name}");
                collection.SelectedItem = null;
            }
        }
    }
}
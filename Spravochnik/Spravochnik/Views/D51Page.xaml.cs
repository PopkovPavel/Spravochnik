using System.Linq;
using Xamarin.Forms;
using Spravochnik.Models;

namespace Spravochnik.Views
{
    public partial class D51Page : ContentPage
    {
        public D51Page()
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
                string D51Name = (e.CurrentSelection.FirstOrDefault() as Fluids).Name;
                await Shell.Current.GoToAsync($"d51details?name={D51Name}");
                collection.SelectedItem = null;
            }
        }
    }
}
using System.Linq;
using Xamarin.Forms;
using Spravochnik.Models;

namespace Spravochnik.Views
{
    public partial class D5Page : ContentPage
    {
        public D5Page()
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
                string D5Name = (e.CurrentSelection.FirstOrDefault() as Fluids).Name;
                await Shell.Current.GoToAsync($"d5details?name={D5Name}");
                collection.SelectedItem = null;
            }
        }
    }
}
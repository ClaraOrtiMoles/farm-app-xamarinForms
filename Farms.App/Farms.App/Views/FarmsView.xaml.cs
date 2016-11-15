using System;
using Farms.App.ViewModel;

using Xamarin.Forms;
using Farms.App.Model;

namespace Farms.App.Views
{
    public partial class FarmsView : ContentPage
    {
        FarmViewModel vm;
        public FarmsView()
        {
            InitializeComponent();
            vm = new FarmViewModel();

            BindingContext = vm;
            ListViewFarms.ItemSelected += ListViewFarms_ItemSelected;
        }

        private async void ListViewFarms_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var farm = e.SelectedItem as FarmModel;
            if (farm == null)
                return;

            await Navigation.PushAsync(new MenuView(farm));

            ListViewFarms.SelectedItem = null;
        }
    }
}

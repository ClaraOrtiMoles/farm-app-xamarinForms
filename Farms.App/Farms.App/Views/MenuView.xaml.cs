using Farms.App.Model;
using Farms.App.Model.Enums;
using Farms.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Farms.App.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuViewModel vm;
        public MenuView(FarmModel currentFarm)
        {
            InitializeComponent();
            vm = new MenuViewModel();
            BindingContext = vm;
            ListViewMenu.ItemSelected += ListViewMenu_ItemSelected;
        }

        private async void ListViewMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var option = e.SelectedItem as OptionModel;
            if (option == null)
                return;
            Page nextPage = this;
            switch (option.Option)
            {
                case (MenuOptionEnum.CurrentCycle):
                    nextPage = new CycleView();
                    break;
                case (MenuOptionEnum.Feed):
                    break;
                case (MenuOptionEnum.Historic):
                    break;
                case (MenuOptionEnum.Maintenance):
                    break;
                case (MenuOptionEnum.PigLet):
                    break;
                case (MenuOptionEnum.Sales):
                    break;
            }

            await Navigation.PushAsync(nextPage);

            ListViewMenu.SelectedItem = null;
        }
    }
}

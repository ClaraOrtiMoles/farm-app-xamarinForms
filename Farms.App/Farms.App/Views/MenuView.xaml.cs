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
        public MenuView()
        {
            InitializeComponent();
            vm = new MenuViewModel();
            BindingContext = vm;
        }
    }
}

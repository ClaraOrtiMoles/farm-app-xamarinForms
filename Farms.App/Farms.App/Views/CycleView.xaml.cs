using Farms.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Farms.App.Views
{
    public partial class CycleView : ContentPage
    {
        private FarmViewModel vm;
        public CycleView()
        {
            InitializeComponent();
            vm = new FarmViewModel();

            BindingContext = vm;
        }
    }
}

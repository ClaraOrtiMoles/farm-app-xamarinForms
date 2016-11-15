using Farms.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Farms.App.Views
{
    public partial class PigLetView : ContentPage
    {
        private PigLetViewModel vm; 
        public PigLetView()
        {
            InitializeComponent();
            vm = new PigLetViewModel();
            BindingContext = vm;
        }
    }
}

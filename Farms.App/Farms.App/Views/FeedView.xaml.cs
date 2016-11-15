using Farms.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Farms.App.Views
{
    public partial class FeedView : ContentPage
    {
        private FeedViewModel vm;
        public FeedView()
        {
            InitializeComponent();
            vm = new ViewModel.FeedViewModel();
            BindingContext = vm;
        }
    }
}

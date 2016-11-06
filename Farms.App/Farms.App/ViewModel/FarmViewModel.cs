using Farms.App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Farms.App.ViewModel
{
    public class FarmViewModel : BaseViewModel
    {
        public FarmViewModel()
        {
            var list = new ObservableCollection<FarmModel>();
            list.Add(new FarmModel { Description = "Masia Nollé", Id = 1 });
            list.Add(new FarmModel { Description = "Barberá", Id = 2 });
            list.Add(new FarmModel { Description = "Piensos Orti", Id = 3 });
            list.Add(new FarmModel { Description = "Coserga", Id = 4 });
            list.Add(new FarmModel { Description = "Cereales Vicens", Id = 5 });
            Farms = list;
        }

        private ObservableCollection<FarmModel> _farms;
        public ObservableCollection<FarmModel> Farms
        {
            get { return _farms; }
            set
            {
                _farms = value;
                OnPropertyChanged();
            }
        }

        public FarmModel _selectedFarm;
        public FarmModel SelectedFarm
        {
            get { return _selectedFarm; }
            set
            {
                _selectedFarm = value;
                OnPropertyChanged();
            }

        }

         
    }
}

using Farms.App.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Farms.App.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<OptionModel> Options { get; set; }

        public MenuViewModel()
        {
            var list = new ObservableCollection<OptionModel>();
            list.Add(new OptionModel { Description = "Ciclo Actual", Id = 1 });
            list.Add(new OptionModel { Description = "Lechones", Id = 2 });
            list.Add(new OptionModel { Description = "Pienso", Id = 3 });
            list.Add(new OptionModel { Description = "Ventas", Id = 4 });
            list.Add(new OptionModel { Description = "Histórico", Id = 5 });
            list.Add(new OptionModel { Description = "Mantenimiento", Id = 6 });
            Options = list;
        }
    }
}

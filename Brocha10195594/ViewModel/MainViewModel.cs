using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brocha10195594.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double precioMetro;

        [ObservableProperty]
        private double metrosPintar;

        [ObservableProperty]
        private double total;

        [RelayCommand]
        private void Presupuesto()
        {
            Total = PrecioMetro * MetrosPintar;
        }
    }
}

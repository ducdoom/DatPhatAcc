using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DatPhatAcc2.Services;
public partial class NavigationService : ObservableObject
{
    private Func<Type, ObservableObject> _viewModelFactory;

    [ObservableProperty]
    private ObservableObject? currentView;

    public NavigationService(Func<Type, ObservableObject> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }

    public void Navigate<TViewModel>() where TViewModel : ObservableObject
    {
        var viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
        CurrentView = viewModel;
    }
}

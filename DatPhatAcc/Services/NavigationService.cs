using CommunityToolkit.Mvvm.ComponentModel;

namespace DatPhatAcc.Services
{
    public interface INavigationService
    {
        ObservableObject CurrentView { get; }
        void Navigate<T>() where T : ObservableObject;
    }

    public partial class NavigationService : ObservableObject, INavigationService
    {
        private Func<Type, ObservableObject> _viewModelFactory;


        [ObservableProperty]
        private ObservableObject currentView;

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
}

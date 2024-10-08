using System;
using PropertyInspecor.Services;
using PropertyInspecor.Views.Pages;

namespace PropertyInspecor.ViewModels
{
    public class LoadingPageViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        private readonly AuthService _authService;

        public LoadingPageViewModel(INavigation navigation, AuthService authService)
        {
            _navigation = navigation;
            _authService = authService;
        }
    }
}

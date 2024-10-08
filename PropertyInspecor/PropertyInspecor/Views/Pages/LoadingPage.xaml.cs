﻿using PropertyInspecor.Services;

namespace PropertyInspecor.Views.Pages;

public partial class LoadingPage : ContentPage
{

    private readonly AuthService _authService;

    public LoadingPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticatedAsync())
        {
            //User is logged in and is redirected to the dashboard
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");
        }
        else
        {
            //User is not logged in and will be redirected to the login page
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
        }
    }
}

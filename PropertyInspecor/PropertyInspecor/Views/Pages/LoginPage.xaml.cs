namespace PropertyInspecor.Views.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(Object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
    }
}

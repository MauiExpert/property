using Controls.UserDialogs.Maui;
using Microsoft.Extensions.Logging;
using PropertyInspecor.Services;
using PropertyInspecor.Views.Pages;
using SimpleToolkit.Core;
using CommunityToolkit.Maui;
using SimpleToolkit.SimpleShell;

namespace PropertyInspecor;


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseUserDialogs(registerInterface: true, () => { })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("icomoon.ttf", "icomoon");
            })
			.UseSimpleToolkit()
			.UseSimpleShell();

        builder.Services.AddTransient<AuthService>();
        builder.Services.AddTransient<LoadingPage>();
        builder.Services.AddTransient<ImagesPage>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<ChecklistPage>();
        builder.Services.AddTransient<AdminPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif


#if ANDROID || IOS
        builder.DisplayContentBehindBars();
#endif


        return builder.Build();
	}
}


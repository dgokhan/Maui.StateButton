﻿using CommunityToolkit.Maui;
using StateButton;

namespace App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		MauiAppBuilder builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("fa-solid-900.ttf", "FASolid900");
			})
			.UseMauiCommunityToolkit()
			.ConfigureStateButton();

		return builder.Build();
	}
}
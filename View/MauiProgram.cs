﻿using Trailfinders.Data;
using Trailfinders.ModelAndViews;

namespace Trailfinders.View;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<HotelPage>();
        builder.Services.AddSingleton<ReservationRepository>();

        return builder.Build();
    }
}

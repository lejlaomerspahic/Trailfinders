using Trailfinders.Data;
using Trailfinders.ModelAndViews;
using Trailfinders.Services;

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



        //Services
        builder.Services.AddSingleton<IReservationService, ReservationService>();

        return builder.Build();
    }
}

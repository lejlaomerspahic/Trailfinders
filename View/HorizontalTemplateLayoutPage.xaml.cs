using Trailfinders.ModelAndViews;
using Trailfinders.Models;
using Trailfinders.View;

namespace Trailfinders;

public partial class HorizontalTemplateLayoutPage : ContentPage
{
    public HorizontalTemplateLayoutPage()
    {
        InitializeComponent();
        BindingContext = new HotelViewModel();
        BindingContext = new FlightViewModel();
        BindingContext = new AttractionViewModel();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hotels());
    }
   private async void Button_Clicked1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Flights());
    }

    private  async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Attractions());
    }
}

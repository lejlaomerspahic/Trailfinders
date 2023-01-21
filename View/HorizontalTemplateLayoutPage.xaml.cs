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
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hotels());
    }
}

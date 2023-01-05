using Trailfinders.ModelAndViews;

namespace Trailfinders.View;

public partial class HorizontalTemplateLayoutPage : ContentPage
{
    public HorizontalTemplateLayoutPage()
    {
        InitializeComponent();
        BindingContext = new HotelViewModel();
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
      // await Navigation.PushModalAsync(new HotelPage());
   // }
}

using Trailfinders.Data;
using Trailfinders.ModelAndViews;
using Trailfinders.Models;

namespace Trailfinders;

public partial class HorizontalTemplateLayoutPage : ContentPage
{
    
    public HorizontalTemplateLayoutPage()
    {
        InitializeComponent();
        BindingContext = new HotelViewModel();
    }

    

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniHotel = (Hotel)myListView.SelectedItem;
        await Navigation.PushAsync(new NavigationPage(new HotelPage(odabraniHotel)));
        
    }
}

using Trailfinders.ModelAndViews;
using Trailfinders.Models;

namespace Trailfinders.View;

public partial class Hotels : ContentPage
{
    public Hotels()
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
using Trailfinders.ModelAndViews;
using Trailfinders.Models;

namespace Trailfinders;

public partial class Flights : ContentPage
{
    public Flights()
    {
        InitializeComponent();
        BindingContext = new FlightViewModel();
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniHotel = (Flight)myListView.SelectedItem;
        await Navigation.PushAsync(new NavigationPage(new FlightPage(odabraniHotel)));
    }
}
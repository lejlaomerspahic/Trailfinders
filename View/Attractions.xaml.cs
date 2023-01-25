using Trailfinders.ModelAndViews;
using Trailfinders.Models;

namespace Trailfinders;

public partial class Attractions : ContentPage
{
    public Attractions()
    {
        InitializeComponent();
        BindingContext = new AttractionViewModel();
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabraniHotel = (Attraction)myListView.SelectedItem;
        await Navigation.PushAsync(new NavigationPage(new AttractionPage(odabraniHotel)));
    }
}
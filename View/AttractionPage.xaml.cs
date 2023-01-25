

using System.Reflection.Metadata;
using Trailfinders.Data;
using Trailfinders.Models;
using Trailfinders.ModelAndViews;
using Trailfinders.Services;

namespace Trailfinders;
public partial class AttractionPage : ContentPage
{
    int count = 1;
    Attraction Attraction;

    public AttractionPage(Attraction odabraniAttraction)
    {
        InitializeComponent();
        name.Text = odabraniAttraction.Name;
        location.Text = odabraniAttraction.Location;
        imageUrl.Source = odabraniAttraction.ImageUrl;
        details.Text = odabraniAttraction.Details;
        information.Text = odabraniAttraction.Information;
        price.Text = odabraniAttraction.Price.ToString();
        Attraction = odabraniAttraction;

    }



}
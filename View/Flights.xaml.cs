using Trailfinders.ModelAndViews;
using Trailfinders.Models;

namespace Trailfinders.View;

public partial class Flights : ContentPage
{
    public Flights()
    {
        InitializeComponent();
        BindingContext = new FlightViewModel();
    }

   
}
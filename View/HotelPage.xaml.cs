

using Trailfinders.ModelAndViews;

namespace Trailfinders;
public partial class HotelPage : ContentPage
{
 
    public HotelPage(HotelDetailsViewModel vm) 
    {
		InitializeComponent();
        BindingContext= vm;
    }


}
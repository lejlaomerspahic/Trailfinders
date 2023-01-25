

using System.Reflection.Metadata;
using Trailfinders.Data;
using Trailfinders.Models;
using Trailfinders.ModelAndViews;
using Trailfinders.Services;

namespace Trailfinders;
public partial class HotelPage : ContentPage
{
    int count = 1;
    Hotel hotel;

    public HotelPage(Hotel odabraniHotel)
    {
        InitializeComponent();
        name.Text = odabraniHotel.Name;
        location.Text = odabraniHotel.Location;
        imageUrl.Source = odabraniHotel.ImageUrl;
        details.Text = odabraniHotel.Details;
        information.Text = odabraniHotel.Information;
        price.Text = odabraniHotel.Price.ToString();
        hotel =odabraniHotel;

        startDate.MinimumDate = DateTime.Today;
        endDate.MinimumDate = startDate.Date.AddDays(1);
        endDate.MaximumDate = startDate.MinimumDate.AddDays(123);
    }



    private async void Button_Clicked(object sender, EventArgs e)
    {
       if(startDate.Date > endDate.Date)
        {
            DateTime temp = startDate.Date;
            startDate.Date = endDate.Date;
            endDate.Date = temp;

        }else if(startDate.Date == endDate.Date)
        {
            DisplayAlert("Error", "Check-in and check-out dates are the same!", "OK");
        }

        var numberOfDays = (startDate.Date - endDate.Date).TotalDays;
            var price = 0.0;
            if (count > 1)
            {
                price = hotel.Price * (count * 0.7)*numberOfDays;
            }
            else
            {
                price = hotel.Price  * numberOfDays;
            }


        Reservation r = new Reservation();
        r.Name = name.Text;
        r.Location= location.Text;
        r.Price = price*(-1);
        r.ImageUrl= imageUrl.Source.ToString();

        
        ReservationService a = new ReservationService();
        int res = await a.AddReservation(r);

        DisplayAlert("RESERVATION", "Reservation succeeded", "OK");
    }

    private void numberOfPeopleCount2(object sender, EventArgs e)
    {
        count++;
        if (count == 1)
            numberOfPeople.Text = $"Number of people: {count}";
        else
            numberOfPeople.Text = $"Number of people:  {count}";

        SemanticScreenReader.Announce(numberOfPeople.Text);
    }

    private void numberOfPeopleCount1(object sender, EventArgs e)
    {
       
        if (count <= 1)
            numberOfPeople.Text = $"Number of people:  {count}";
        else
            count--;
            numberOfPeople.Text = $"Number of people:  {count}";

        SemanticScreenReader.Announce(numberOfPeople.Text);
    }
}
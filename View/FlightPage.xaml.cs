using System.Reflection.Metadata;
using Trailfinders.Data;
using Trailfinders.Models;

namespace Trailfinders;
public partial class FlightPage : ContentPage
{
    int count = 1;
    Flight hotel;

    public FlightPage(Flight odabraniHotel)
    {
        InitializeComponent();
        name.Text = odabraniHotel.DeparturePlace;
        location.Text = odabraniHotel.ArrivalPlace;
        imageUrl.Source = odabraniHotel.ImageUrl;
        details.Text = odabraniHotel.Details;
        information.Text = odabraniHotel.Information;
        price.Text = odabraniHotel.Price.ToString();
        hotel =odabraniHotel;

        startDate.MinimumDate = DateTime.Today;
        endDate.MinimumDate = startDate.Date.AddDays(1);
        endDate.MaximumDate = startDate.MinimumDate.AddDays(123);
    }




    private void Button_Clicked(object sender, EventArgs e)
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



        string poruka =  "\r\nTotal price: " + price*(-1) + " EUR" +
                                       "\r\nNumber of people: " + count.ToString() +
                       "\r\nCheck-in date: " + startDate.Date.ToString("dd.M.yyyy.") +
                                       "\r\nCheck-out date: " + endDate.Date.ToString("dd.M.yyyy.");
            DisplayAlert("RESERVATION", poruka, "OK");
        
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
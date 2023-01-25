using System.Reflection.Metadata;
using Trailfinders.Data;
using Trailfinders.Models;
using Trailfinders.Services;

namespace Trailfinders;
public partial class FlightPage : ContentPage
{
    int count = 1;
    Flight hotel;
    public List<Flight> Lista { get; set; }

    public FlightPage(Flight odabraniHotel)
    {
        InitializeComponent();
        name.Text = odabraniHotel.DeparturePlace;
        location.Text = odabraniHotel.ArrivalPlace;
        imageUrl.Source = odabraniHotel.ImageUrl;
        information.Text = odabraniHotel.Information;
        price.Text = odabraniHotel.Price.ToString();
        hotel =odabraniHotel;

     
        startDate.MinimumDate = DateTime.Today;

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        double total = 0.0;
        Console.WriteLine("1 je " + total);
        if (startDate.Date > endDate.Date)
        {
            DateTime temp = startDate.Date;
            startDate.Date = endDate.Date;
            endDate.Date = temp;

        }else if(OneWay.IsChecked)
        {
            startDate.Date = endDate.Date;
            total += hotel.Price;

        }else if (Return.IsChecked)
        {
            OneWay.IsChecked = false;
            total+= hotel.Price * 1.8;

        }

        total *= count;

        Reservation r = new Reservation();
        r.Name = name.Text;
        r.Location = location.Text;
        r.Price = total;
        r.ImageUrl = imageUrl.Source.ToString();


        ReservationService a = new ReservationService();
        int res = await a.AddReservation(r);

        DisplayAlert("RESERVATION", "Reservation succeeded", "OK");
        List<Reservation> list = await a.GetReservationList();


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
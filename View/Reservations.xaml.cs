namespace Trailfinders;
using Trailfinders.Models;
using Trailfinders.Services;


public partial class Reservations : ContentPage
{
    List<Reservation> reservations;
    ReservationService reservationService;


    public Reservations()
    {
        InitializeComponent();
        reservationService = new ReservationService();
        reservations = new List<Reservation>();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        reservations = await reservationService.GetReservationList();
        for (int i = 0; i < reservations.Count; i++)
        {
            reservations[i].ImageUrl = reservations[i].ImageUrl.Replace("Uri: ", "");
            String[] temp = reservations[i].Location.Split(',');
            reservations[i].Location = temp[0];


        }
        listViewReservations.ItemsSource = reservations;
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button != null)
        {
            if (button.CommandParameter is Reservation data)
            {
                await reservationService.DeleteReservation(data);
            }
        }
    }

}
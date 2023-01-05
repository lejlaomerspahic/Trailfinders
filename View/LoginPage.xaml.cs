namespace Trailfinders;

using Trailfinders.Models;
public partial class LoginPage : ContentPage
{
    public User _user;

    public LoginPage()
    {

        InitializeComponent();
    }
    public LoginPage(User user)
    {
        InitializeComponent();
        _user = user;

    }

    private void PrijavaButton_Clicked(object sender, EventArgs e)
    {
        if (_user == null)
        {
            DisplayAlert("Greška", "Nema registrovanih korisnika!", "OK");
        }
        else if (UsernamEntry.Text != _user.UserName)
        {
            DisplayAlert("Greška", "Korisničko ime ne postoji u sistemu!", "OK");
        }
        else if (PassEntry.Text != _user.Password)
        {
            DisplayAlert("Greška", "Pogrešna korisnička šifra!", "OK");
        }
        else
        {
            Navigation.PushModalAsync(new AppTabbedPage());
        }
    }


    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registracija());
    }
}


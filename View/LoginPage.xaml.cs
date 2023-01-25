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
            DisplayAlert("Error", "There are no registered users!", "OK");
        }
        else if (UsernamEntry.Text != _user.UserName)
        {
            DisplayAlert("Error", "Username doesn't exist in the system!", "OK");
        }
        else if (PassEntry.Text != _user.Password)
        {
            DisplayAlert("Error", "Wrong password!", "OK");
        }
        else
        {
            Navigation.PushModalAsync(new AppFlyout());
        }
    }


    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registracija());
    }
}


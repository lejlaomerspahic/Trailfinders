using Trailfinders.Models;
namespace Trailfinders;
public partial class Registracija : ContentPage
{
	public Registracija()
	{
		InitializeComponent();
	}

    private void CreateUserButton_Clicked(object sender, EventArgs e)
    {
        if ((UsernamEntry.Text != null) && (PassEntry.Text != null) && (PassEntryAgain.Text != null))
        {
            if (PassEntry.Text != PassEntryAgain.Text)
            {
                DisplayAlert("Greška", "Korisnička šifra i ponovljena korisnička šifra moraju biti identične!", "OK");
            }
            else
            {
                User _user = new User();

                _user.UserName = UsernamEntry.Text;
                _user.Password = PassEntry.Text;

                Navigation.PushModalAsync(new LoginPage(_user));
               /* var userData = (User)BindingContext;
                UserData database = await UserData.Instance;
                await database.SaveItemAsync(userData);
                await Navigation.PopAsync();*/
            }
        }
        else
        {
            DisplayAlert("Greška", "Sva polja moraju biti specificirana!", "OK");
        }
    }

}
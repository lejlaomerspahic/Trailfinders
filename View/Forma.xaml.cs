namespace Trailfinders;

public partial class Forma : ContentPage
{
	public Forma()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppFlyout());
    }
}
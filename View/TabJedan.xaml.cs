using System.Windows.Input;
using Trailfinders.View;

namespace Trailfinders;

public partial class TabJedan : ContentPage
{

    public TabJedan()
    {
        InitializeComponent();

        
    }

    public async void redirect(object sender, EventArgs e)
    {        
        //App.Current.MainPage = new NavigationPage(new HorizontalTemplateLayoutPage());
        await Navigation.PushModalAsync(new HorizontalTemplateLayoutPage());
    }
}

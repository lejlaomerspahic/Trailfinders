namespace Trailfinders;

public partial class AppTabbedPage:TabbedPage
{
	public AppTabbedPage()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(HotelPage), typeof(HotelPage));

	}
}
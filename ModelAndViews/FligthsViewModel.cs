using Trailfinders.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Trailfinders.ModelAndViews
{
    public partial class FlightViewModel : ObservableObject
    {
        readonly IList<Flight> source;
        public ObservableCollection<Flight> Flights { get; private set; }
        public ICommand FilterCommand => new Command<string>(FilterItems);

        public FlightViewModel()
        {
            source = new List<Flight>();
            CreateFlightCollection();

        }
        async Task goToDetalsAsync(Flight hotel)
        {
            if (Flights is null) return;

            await Shell.Current.GoToAsync($"{nameof(FlightPage)}", true,
                new Dictionary<string, object>
                {
                    {"Flights", hotel}
                });
        }
        void CreateFlightCollection()
        {
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Budapest",
                Details = "One way flight",
                Information = "One way flight with Australian Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/R.be445cfe309d014520acb3268e5cc20d?rik=CdFD%2fwlhmD5g%2fQ&riu=http%3a%2f%2fee24.com%2fmedia%2fuploads%2f2016%2f10%2f31%2fkdjtbh.jpg&ehk=t1Fih6JXlfeojDwhD27FN4NzAbm2zdPYqO6v94HpEKg%3d&risl=&pid=ImgRaw&r=0",
                Price = 1200,
            });
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Tokyo",
                Details = "One way flight",
                Information = "One way flight with Australian Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/R.799e9fa0d32676b6b9c70de112e90df0?rik=65apPsnwoUadkw&riu=http%3a%2f%2fshibuya246.com%2fwp-content%2fuploads%2f2012%2f08%2fTokyo-View.jpg&ehk=hi4apwZjhfvMb2t1vpYBp5n5F3kMH3WANq7bhrhaPGs%3d&risl=1&pid=ImgRaw&r=0",
                Price = 200,
            });

            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Washington",
                Details = "One way flight",
                Information = "One way flight with Turkish Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/OIP.cYCJs7CsDv9146xZlHaG4gHaE8?pid=ImgDet&w=5633&h=3757&rs=1",
                Price = 1000,
            });
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Istanbul",
                Details = "One way flight",
                Information = "One way flight with Anadalu Jet. Return ticket is 80% more expensieve.",
                ImageUrl = "https://i1.wp.com/svguidinglight.wpengine.com/wp-content/uploads/2016/08/Turkey-Istanbul-Blue-Mosque-Exterior.jpg",
                Price = 200,
            });

            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Paris",
                Details = "One way flight",
                Information = "One way flight with Austrian Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://loveincorporated.blob.core.windows.net/contentimages/gallery/055c7e3a-de9a-4b7b-a538-9c1f86e4245e-Eiffel_Tower_now_Valery_Egorov_Shutterstock.jpg",
                Price = 300,
            });

            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Amsterdam",
                Details = "One way flight",
                Information = "One way flight with Lufthansa. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/R.e2a2d3bab49c119c0af8be5efb6d9bd8?rik=vl0ZJh7S7H71lQ&pid=ImgRaw&r=0",
                Price = 200,
            });
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "New York",
                Details = "One way flight",
                Information = "One way flight with Lufthansa. Return ticket is 80% more expensieve.",
                ImageUrl = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/2/new-york-city-manhattan-midtown-empire-state-building-cityscape-with-the-empire-state-building-and-the-freedom-tower-as-seen-from-top-of-the-rock-observation-deck-at-the-rockefeller-center-at-night-antonino-bartuccio.jpg",
                Price = 1200,
            });
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Brasilia",
                Details = "One way flight",
                Information = "One way flight with Lufthansa. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/R.d5a9d2e8e025aedc32774aec9df2b620?rik=sp6GM8Fyw4V1fQ&pid=ImgRaw&r=0",
                Price = 1500,
            });
            
           
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Borneo",
                Details = "One way flight",
                Information = "One way flight with Turkish Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/OIP.cWIvUvHqCy67ZEv5M0uzUAHaE8?pid=ImgDet&rs=1",
                Price = 200,
            });

            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Dubai",
                Details = "One way flight",
                Information = "One way flight with FlyDubai. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/OIP.VVe7E5WqUyj8FePAy9wXUwHaE8?pid=ImgDet&rs=1",
                Price = 1500,
            });
            source.Add(new Flight
            {
                ID = 1,
                DeparturePlace = "Sarajevo",
                ArrivalPlace = "Maldivi",
                Details = "One way flight",
                Information = "One way flight with Australian Airlines. Return ticket is 80% more expensieve.",
                ImageUrl = "https://th.bing.com/th/id/OIP.pmHNzcLjm0kcEjP7m2zSTAHaE7?pid=ImgDet&rs=1",
                Price = 1200,
            });



            Flights = new ObservableCollection<Flight>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Flight => Flight.ArrivalPlace.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Flight in source)
            {
                if (!filteredItems.Contains(Flight))
                {
                    Flights.Remove(Flight);
                }
                else
                {
                    if (!Flights.Contains(Flight))
                    {
                        Flights.Add(Flight);
                    }
                }
            }
        }

    }
}

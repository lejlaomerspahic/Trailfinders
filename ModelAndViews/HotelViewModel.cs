using Trailfinders.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Trailfinders.ModelAndViews
{
    public partial class HotelViewModel: ObservableObject
    {
        readonly IList<Hotel> source;
        public ObservableCollection<Hotel> Hotels { get; private set; }
        public ICommand FilterCommand => new Command<string>(FilterItems);


        public HotelViewModel()
        {
            source = new List<Hotel>();
            CreateHotelCollection();
        
        }
        async Task goToDetalsAsync(Hotel hotel)
        {
            if(Hotels is null) return;

            await Shell.Current.GoToAsync($"{nameof(HotelPage)}", true,
                new Dictionary<string, object>
                {
                    {"Hotels", hotel}
                });
        }
        void CreateHotelCollection()
        {
            source.Add(new Hotel
            {
                ID = 4,
                Name = "The Westin New York",
                Location = "New York, United States",
                Details = "Traditional double guest room",
                Information = "Standing at Times Square, this Manhattan luxury hotel " +
                "features an on-site restaurant and bar. The 42nd Street-Port Authority subway station is located just outside the hotel.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/24381693.jpg?k=1c0097441412b2b6fb7041d989e1902e11049be12a4251a09d7d465259464d25&o=&hp=1",
                Price = 100,
            });
            source.Add(new Hotel
            {
                ID = 1,
                Name = "Hotel AJWA Sultanahmet",
                Location = "Istanbul, Turkey",
                Details = "Standard Room with Queen Bed",
                Information= "This special class category hotel is situated in old quarter of the city." +
                " It features a spa and a roof-top terrace with panoramic views of Istanbul and the Marmara Sea",
                ImageUrl = "https://i.pinimg.com/originals/1b/54/f1/1b54f1db2a7e441aa1da87261120b581.jpg",
                Price = 150,
            });

            source.Add(new Hotel
            {
                ID = 2,
                Name = "Hotel Elysees Opera",
                Location = "Paris, France",
                Details = "Modern guest rooms with a balcony",
                Information= "Alp Hotel is a small and charming hotel right in the Paris city centre," +
                "600 metres from main neighbourhood. The hotel includes free Wi-Fi and a terrace.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/107785875.jpg?k=e45fbf035376d706bf80d4aa9913469235224a68c543be7fae5b2395c0c91e74&o=&hp=1",
                Price = 100,
            });

            source.Add(new Hotel {
                ID = 3, 
                Name = "Vila Suzana Parque Hotel",
                Location = "Amsterdam, Netherlands", 
                Details = "Small Double Room", 
                Information= "Vila Suzana Parque Hotel is located alongside the Amstel river in Amsterdam. " +
                "This hotel combines luxury, technology and sustainability in a living building shaped by nature.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822491.jpg?k=dc636958ccd56248febe13031bea5c2ba142ab7b015b1520604ea3d8e8c0bf4a&o=&hp=1", 
                Price = 100,
            });
            
            

            source.Add(new Hotel
            {
                ID = 5,
                Name = "Golden Lion Tamarin",
                Location = "Brasilia, Brasil",
                Details = "Standard double Room",
                Information = "Boasting a rooftop swimming pool with city views, a gym and a sauna, " +
                "Golden Lion Tamarin is located between the Television Tower and City Park and includes free WiFi.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327080575.jpg?k=a1a978598bc11e2a9c1ec539ea6d4fee764f2cd4972008691c23a43ed7f87e63&o=&hp=1",
                Price = 100,
            }) ;

            source.Add(new Hotel
            {
                ID = 6,
                Name = "Hard Rock Hotel Budapest",
                Location = "Budapest, Hungary",
                Details = "Private suite",
                Information= "Set in Budapest, 300 metres from Hungarian State Opera, " +
                "Hard Rock Hotel Budapest offers accommodation with a restaurant, private parking, a fitness centre and a bar.",
                ImageUrl = "https://www.hardrockhotels.com/budapest/files/6004/Platinum_Suite_-_Bedroom.jpg",
                Price = 200,
            });

            source.Add(new Hotel
            {
                ID = 7,
                Name = "Japanese Macaque",
                Location = "Tokyo, Japan",
                Details = "Superior Double Room",
                Information= "This 6-star hotel offers modern rooms with free Wi-Fi. " +
                "It is less than 10 minutes' walk from the center. " +
                "The hotel has a gym and a sauna.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/197652579.jpg?k=2322075968b4904b2904fad038323d5bb1241b22fdf05ed9aa4bfec097e12bbb&o=&hp=1",
                Price = 250,
            });

            source.Add(new Hotel
            {
                ID = 9,
                Name = "Grand Kecubung Hotel",
                Location = "Borneo, Indonesia",
                Details = "Modern confort twin Room",
                Information= "Modern comfort awaits guests at Grand Kecubung Hotel. " +
                "Featuring a gym and an outdoor pool, " +
                "it houses air-conditioned rooms with private bathrooms.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822486.jpg?k=438b3aa6bd2fca3281161b891ba6b9fea37919b66fbc3acd19ba3b7b3d969e28&o=&hp=1",
                Price=100,
            });

           
            source.Add(new Hotel
            {
                ID = 10,
                Name = "Dubai Deira Hotel",
                Location = "Dubai, Emirates",
                Details = "Deluxe Room",
                Information= "Just 300 metres from Reef Shopping Mall, " +
                "this 5-star hotel has an outdoor rooftop pool and spacious air-conditioned rooms in Deira District.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/178289405.jpg?k=2298d157c7a9748e25bf8fd05cd110617ad20519436dcaaab61ff81e511b06d6&o=&hp=1",
                Price=300,
            });

            source.Add(new Hotel
            {
                ID = 11,
                Name = "Niyama Private Hotel",
                Location = "Maldives",
                Details = "Beach Room",
                Information= "Luxurious hotel is tropical paradise " +
                "offering a quiet private beach and free WiFi is available in the rooms and" +
                " throughout the resort. Rooms offered are luxurious over water pool villas.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/181288994.jpg?k=fc418ac173ad7efc768a6c239d29c566f5ffdb657d1889d88002ceba9f18078d&o=&hp=1",
                Price=300,
            });

            source.Add(new Hotel
            {
                ID = 12,
                Name = "Riu Atoll",
                Location = "Male, Maldives",
                Details = "Beach Villa",
                Information = "Facing the beachfront, Riu Atoll-All Inclusive offers 4-star accommodation " +
                "in Dhaalu Atoll and has an outdoor swimming pool, fitness centre and garden.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/99060502.jpg?k=fb996e90440c44c118afa23199c26db92cfbb62ff0f5e2ae87c146c1785320e5&o=&hp=1",
                Price = 300,
            });

            source.Add(new Hotel
            {
                ID = 13,
                Name = "Hilton Garden Inn",
                Location = "New York, United States",
                Details = "King Room",
                Information= "Located 805 metres from Times Square," +
                " Hilton Garden Inn offers complimentary " +
                "WiFi and a breakfast buffet to all its guests.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822494.jpg?k=69e3f7ee1772ff5f7426585e948484a8a7ba42e80713e912abbfaaf0e07ba6b4&o=&hp=1",
                Price = 300,
            });

            Hotels = new ObservableCollection<Hotel>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Hotel => Hotel.Name.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Hotel in source)
            {
                if (!filteredItems.Contains(Hotel))
                {
                    Hotels.Remove(Hotel);
                }
                else
                {
                    if (!Hotels.Contains(Hotel))
                    {
                        Hotels.Add(Hotel);
                    }
                }
            }
        }
     
    }
}

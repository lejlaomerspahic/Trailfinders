using Trailfinders.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Trailfinders.ModelAndViews
{
    public partial class HotelViewModel: ObservableObject
    {
        readonly IList<Hotel> source;
        public ObservableCollection<Hotel> Hotels { get; private set; }
        public IList<Hotel> EmptyHotels { get; private set; }

        public Hotel PreviousHotel { get; set; }
        public Hotel CurrentHotel { get; set; }
        public Hotel CurrentItem { get; set; }
        public int PreviousPosition { get; set; }
        public int CurrentPosition { get; set; }
        public int Position { get; set; }

        public ICommand FilterCommand => new Command<string>(FilterItems);
        public ICommand ItemChangedCommand => new Command<Hotel>(ItemChanged);
        public ICommand PositionChangedCommand => new Command<int>(PositionChanged);
        public ICommand DeleteCommand => new Command<Hotel>(RemoveHotel);
        public ICommand FavoriteCommand => new Command<Hotel>(FavoriteHotel);


        public HotelViewModel()
        {
            source = new List<Hotel>();
            CreateHotelCollection();

            CurrentItem = Hotels.Skip(3).FirstOrDefault();
            OnPropertyChanged("CurrentItem");
            Position = 3;
            OnPropertyChanged("Position");
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
                ID = 1,
                Name = "Hotel AJWA Sultanahmet",
                Location = "Istanbul, Turkey",
                Details = "Standard Room with Queen Bed",
                ImageUrl = "https://i.pinimg.com/originals/1b/54/f1/1b54f1db2a7e441aa1da87261120b581.jpg",
                Price = 150,
            });

            source.Add(new Hotel
            {
                ID = 2,
                Name = "Hotel Elysees Opera",
                Location = "Paris, France",
                Details = "Modern guest rooms with a balcony",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/107785875.jpg?k=e45fbf035376d706bf80d4aa9913469235224a68c543be7fae5b2395c0c91e74&o=&hp=1",
                Price = 100,
            });

            source.Add(new Hotel {
                ID = 3, 
                Name = "Vila Suzana Parque Hotel",
                Location = "Amsterdam, Netherlands", 
                Details = "Small Double Room", 
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822491.jpg?k=dc636958ccd56248febe13031bea5c2ba142ab7b015b1520604ea3d8e8c0bf4a&o=&hp=1", 
                Price = 100,
            });
            
            source.Add(new Hotel
            {
                ID = 4,
                Name = "The Westin New York",
                Location = "New York, United States",
                Details = "Traditional double guest room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/24381386.jpg?k=bf782b9ab5fc2ebc9dc0f115303ad58d6b83c7e190ab136a6d41b32326802383&o=&hp=1",
                Price = 100,
            });

            source.Add(new Hotel
            {
                ID = 5,
                Name = "Golden Lion Tamarin",
                Location = "Brasilia, Brasil",
                Details = "Standard double Room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/327080575.jpg?k=a1a978598bc11e2a9c1ec539ea6d4fee764f2cd4972008691c23a43ed7f87e63&o=&hp=1",
                Price = 100,
            });

            source.Add(new Hotel
            {
                ID = 6,
                Name = "Hard Rock Hotel Budapest",
                Location = "Budapest, Hungary",
                Details = "Private suite",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/335034022.jpg?k=2dfdd36a3fbfa275a7d764ab5b751511e8ec462510e434ebea061761bb86536e&o=&hp=1",
                Price = 200,
            });

            source.Add(new Hotel
            {
                ID = 7,
                Name = "Japanese Macaque",
                Location = "Tokyo, Japan",
                Details = "Superior Double Room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/197652579.jpg?k=2322075968b4904b2904fad038323d5bb1241b22fdf05ed9aa4bfec097e12bbb&o=&hp=1",
                Price = 250,
            });

            source.Add(new Hotel
            {
                ID = 8,
                Name = "Mandrill",
                Location = "Kinshasa, Congo",
                Details = "King Studio with Sofa Bed",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/214654840.jpg?k=c847670dd9a0deeb4f35bc99afb7141663196aed3b3c7c2abdc98c736d9b5928&o=&hp=1",
                Price=50,
            });

            source.Add(new Hotel
            {
                ID = 9,
                Name = "Proboscis Hotel",
                Location = "Borneo, Indonesia",
                Details = "Small Twin Room with balcony",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822486.jpg?k=438b3aa6bd2fca3281161b891ba6b9fea37919b66fbc3acd19ba3b7b3d969e28&o=&hp=1",
                Price=100,
            });

           
            source.Add(new Hotel
            {
                ID = 10,
                Name = "Dubai Deira Hotel",
                Location = "Dubai, Emirates",
                Details = "Deluxe Room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/178289405.jpg?k=2298d157c7a9748e25bf8fd05cd110617ad20519436dcaaab61ff81e511b06d6&o=&hp=1",
                Price=300,
            });

            source.Add(new Hotel
            {
                ID = 11,
                Name = "Niyama Private Hotel",
                Location = "Maldives",
                Details = "Beach Room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/181288994.jpg?k=fc418ac173ad7efc768a6c239d29c566f5ffdb657d1889d88002ceba9f18078d&o=&hp=1",
                Price=300,
            });

            source.Add(new Hotel
            {
                ID = 12,
                Name = "Riu Atoll",
                Location = "Male, Maldives",
                Details = "Beach Villa",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/99060502.jpg?k=fb996e90440c44c118afa23199c26db92cfbb62ff0f5e2ae87c146c1785320e5&o=&hp=1",
                Price = 300,
            });

            source.Add(new Hotel
            {
                ID = 13,
                Name = "Hilton Garden Inn",
                Location = "New York, United States",
                Details = "King Room",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/326822494.jpg?k=69e3f7ee1772ff5f7426585e948484a8a7ba42e80713e912abbfaaf0e07ba6b4&o=&hp=1",
                Price = 300,
            });

            Hotels = new ObservableCollection<Hotel>(source);
        }

        [CommunityToolkit.Mvvm.Input.RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync(nameof(HotelPage));
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

        void ItemChanged(Hotel item)
        {
            PreviousHotel = CurrentHotel;
            CurrentHotel = item;
            OnPropertyChanged("PreviousHotel");
            OnPropertyChanged("CurrentHotel");
        }

        void PositionChanged(int position)
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
            OnPropertyChanged("PreviousPosition");
            OnPropertyChanged("CurrentPosition");
        }

        void RemoveHotel(Hotel Hotel)
        {
            if (Hotels.Contains(Hotel))
            {
                Hotels.Remove(Hotel);
            }
        }

        void FavoriteHotel(Hotel Hotel)
        {
            Hotel.IsFavorite = !Hotel.IsFavorite;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

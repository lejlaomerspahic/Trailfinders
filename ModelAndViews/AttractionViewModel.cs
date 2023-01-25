
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Trailfinders.Models;

namespace Trailfinders.ModelAndViews
{
    public partial class AttractionViewModel : ObservableObject
    {
        readonly IList<Attraction> source;
        public ObservableCollection<Attraction> Attractions { get; private set; }

        public ICommand FilterCommand => new Command<string>(FilterItems);


        public AttractionViewModel()
        {
            source = new List<Attraction>();
            CreateAttractionCollection();
        }

        //async Task goToDetalsAsync(Attraction attraction)
        //{
        //    if (Attractions is null) return;

        //    await Shell.Current.GoToAsync($"{nameof(HotelPage)}", true,
        //        new Dictionary<string, object>
        //        {
        //            {"Attraction", attraction}
        //        });
        //}

        void CreateAttractionCollection()
        {
            source.Add(new Attraction
            {
                ID = 12,
                Name = "Statue of Liberty",
                Location = "New York, United States",
                Details = "History statue",
                Information = "One of the most iconic symbols of America, the Statue of Liberty rises up from New York Harbor," +
                "  welcoming the immigrants who once entered the United States through nearby Ellis Island. ",
                ImageUrl = "https://th.bing.com/th/id/OIP.THTq18qBykKI0478A6Jf8AHaHa?pid=ImgDet&rs=1",
            });

            source.Add(new Attraction
            {
                ID = 1,
                Name = "Hagia Sophia",
                Location = "Istanbul, Turkey",
                Details = "Byzantine mosque and museum",
                Information = "Hagia Sophia officially the Hagia Sophia Grand Mosque, is a mosque and major cultural and historical site in Istanbul, Turkey.",
                ImageUrl = "https://th.bing.com/th/id/R.900bd30ae8a82c36f84a7c9553996c62?rik=erRZ5eaY2YGmtg&pid=ImgRaw&r=0",
            });

            source.Add(new Attraction
            {
                ID = 2,
                Name = "Topkapi Palace",
                Location = "Istanbul, Turkey",
                Details = "Museum",
                Information = "This enormous palace was the Imperial residence of Ottoman sultans for almost 400 years. Although much of the palace is not accessible, the daily tours of the Harem are of great interest to tourists. ",
                ImageUrl = "https://th.bing.com/th/id/R.4c5efedd51e4b590939d82c47a682688?rik=9XAdVAAL5VMPDg&pid=ImgRaw&r=0",
                Price = 25,
            });

            source.Add(new Attraction
            {
                ID = 3,
                Name = "Anne Frank House",
                Location = "Amsterdam, Netherlands",
                Details = "Museum",
                Information = "The Anne Frank House is a museum dedicated to Jewish wartime diarist Anne Frank. The building is located on a canal called the Prinsengracht, close to the Westerkerk, in central Amsterdam in the Netherlands. ",
                ImageUrl = "https://media.cntraveler.com/photos/55e0aedcf073f4db6484912a/master/w_1200,c_limit/anne-frank-house-cr-alamy.jpg",
                Price = 35,
            });

            source.Add(new Attraction
            {
                ID = 4,
                Name = "Empire State Building",
                Location = "New York, United States",
                Details = "Traditional double guest room",
                Information = "The Empire State Building is the World's Most Famous Building. It rises 1,454 ft from ground to antenna & features the only 360 degree open-air vantage point of Midtown.",
                ImageUrl = "https://cdn.vox-cdn.com/thumbor/cadxy62onBm0RdCiOONK_h3vNYs=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/8314737/shutterstock_341129564.jpg",
                Price = 50,
            });

            source.Add(new Attraction
            {
                ID = 5,
                Name = "Memorial JK",
                Location = "Brasilia, Brasil",
                Details = "History Museums",
                Information = "Many visit the site of President Kubitschek’s memorial, featuring a tastefully inscribed plaque in honor of the beloved leader.",
                ImageUrl = "https://th.bing.com/th/id/R.d96ac880f55bb4c0f361199555af364b?rik=Jv3P%2fhwCi5%2bw0w&riu=http%3a%2f%2filovetrip.com.br%2fwp-content%2fuploads%2fmuseus-em-brasilia-memorial-jk-estatuas.jpg&ehk=hlgjEDeVfIEGiJUyy3UMfptW6zJjvUOZt2m%2fTqwUQh4%3d&risl=&pid=ImgRaw&r=0",
                Price = 30,
            });

            source.Add(new Attraction
            {
                ID = 6,
                Name = "Hungarian Parliament",
                Location = "Budapest, Hungary",
                Details = "Architectural Buildings",
                Information = "The domed neo-Gothic structre was inspired by the British House of Parliament and serves as both a vibrant government center and a proud city landmark on the banks of the Danube.",
                ImageUrl = "https://images6.alphacoders.com/899/899256.jpg",
            });

            source.Add(new Attraction
            {
                ID = 7,
                Name = "Ginza",
                Location = "Tokyo, Japan",
                Details = "Neighborhood",
                Information = "This large neighborhood is home to many stores and restaurants " +
                "and is a favorite destination for the youth of Tokyo. ",
                ImageUrl = "https://th.bing.com/th/id/R.39239395f055328ddf7a13a8c8df1fd1?rik=vYMKap4nGywIyg&pid=ImgRaw&r=0",
            });

            source.Add(new Attraction
            {
                ID = 8,
                Name = "Burj Khalifa",
                Location = "Dubai, Emirates",
                Details = "Deluxe Room",
                Information = "Described as both a ‘Vertical City’ and ‘A Living Wonder,’ Burj Khalifa, " +
                "developed by Dubai-based Emaar Properties PJSC, is the world’s tallest building. Rising gracefully from the desert, " +
                "Burj Khalifa honours the city with its extraordinary union of art, engineering and meticulous craftsmanship.",
                ImageUrl = "https://www.guinnessworldrecords.com/Images/Burj-portrait-lagre_tcm25-475749.jpg",
                Price = 60,
            });

            source.Add(new Attraction
            {
                ID = 9,
                Name = "The Dubai Mall",
                Location = "Dubai, Emirates",
                Details = "Shopping Malls",
                Information = "This downtown mall is known for luxury stores like Cartier and Harry Winston. " +
                "It also has an aquarium, ice rink, and 360-degree views of the city from the world’s tallest building, The Burj Khalifa.",
                ImageUrl = "https://cdn1.goibibo.com/voy_ing/t_fs/dubai-dubai-mall-162049096237o.jpeg",
            });

            source.Add(new Attraction
            {
                ID = 10,
                Name = "Diving Tours",
                Location = "Maldives",
                Details = "Beach Room",
                Information = "One of the most iconic symbols of America, the Statue of Liberty rises up from New York Harbor," + "  welcoming the immigrants who once entered the United States through nearby Ellis Island. " +
                "  and snorkels before heading out to sea.",
                ImageUrl = "https://www.maestroegypttours.com/files/xlarge/1184874-Aqaba-Snorkeling-Tours-in-Taba.jpg",
                Price = 150,
            });

            source.Add(new Attraction
            {
                ID = 11,
                Name = "Swiming with sharks",
                Location = "Male, Maldives",
                Details = "Beach Villa",
                Information = "While sharks are common throughout this incredible diving destination, there’s a handful of iconic atolls and stand-out dive sites which are not to be missed by any shark enthusiast.  ",
                ImageUrl = "https://scontent.fsjj1-1.fna.fbcdn.net/v/t1.6435-9/91911530_241621200555291_5482676047134588928_n.jpg?stp=dst-jpg_p600x600&_nc_cat=100&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=bkaWZOlW_pIAX-sgy-F&_nc_ht=scontent.fsjj1-1.fna&oh=00_AfDmM37DgVhpT5XyVEKp4JFo8Q1G5kAus3GnsguRWw8kcw&oe=63F4B6C4",
                Price = 300,
            });

            
            Attractions = new ObservableCollection<Attraction>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(Attraction => Attraction.Name.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var Attraction in source)
            {
                if (!filteredItems.Contains(Attraction))
                {
                    Attractions.Remove(Attraction);
                }
                else
                {
                    if (!Attractions.Contains(Attraction))
                    {
                        Attractions.Add(Attraction);
                    }
                }
            }
        }
    }
}


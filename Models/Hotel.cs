using SQLite;

namespace Trailfinders.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string Information { get; set; }
        public bool IsFavorite { get; set; }
        public int Price { get; set; }
    }
}

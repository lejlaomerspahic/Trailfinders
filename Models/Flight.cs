
namespace Trailfinders.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string DeparturePlace  { get; set; }
        public string ArrivalPlace { get; set; }
        public string Details { get; set; }
        public string Information { get; set; }
        public string ImageUrl { get; set; }
        public string CompanyName { get; set; }
        public int Price { get; set; }
    }
}

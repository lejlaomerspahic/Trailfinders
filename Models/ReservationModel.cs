using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailfinders.Models
{
    [Table("reservations")]
    class ReservationModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }
        [MaxLength(250), ]
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}

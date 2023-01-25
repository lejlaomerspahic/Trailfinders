
using Trailfinders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailfinders.Services
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationList();

        Task<int> DeleteReservation(Reservation reservation);

        Task<int> UpdateReservation(Reservation reservation);
        Task<int> AddReservation(Reservation reservation);
    }
}

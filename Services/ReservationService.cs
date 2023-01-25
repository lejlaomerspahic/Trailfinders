

using SQLite;
using Trailfinders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailfinders.Services
{
    public class ReservationService : IReservationService
    {
        public SQLiteAsyncConnection _dbConnection;
        public ReservationService()
        {
            SetupDatabase();
        }

        private async void SetupDatabase()
        {
            if (_dbConnection == null)
            {
                string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Reservation.db3");
                _dbConnection = new SQLiteAsyncConnection(dbpath);
                _dbConnection.CreateTableAsync<Reservation>();
            }

        }

        public Task<int> AddReservation(Reservation reservation)
        {
            return _dbConnection.InsertAsync(reservation);

        }

        public Task<int> DeleteReservation(Reservation reservation)
        {
            return _dbConnection.DeleteAsync(reservation);
        }


        public Task<List<Reservation>> GetReservationList()
        {
            var reservationList = _dbConnection.Table<Reservation>().ToListAsync();

            return reservationList;

        }
        public Task<int> UpdateReservation(Reservation reservation)
        {
            return _dbConnection.UpdateAsync(reservation);
        }
    }
}

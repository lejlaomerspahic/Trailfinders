using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trailfinders.Models;

namespace Trailfinders.Data
{
    public class ReservationRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteConnection conn;

        private void Init()
        {

            // TODO: Add code to initialize the repository
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<ReservationModel>();
        }

        

        public void AddNewReservation(string name, string location, string imageUrl, double price)
        {
                  Console.WriteLine("dfvadafvfdgfgvargadfafgafsggafsgdggfdgfdgfgfgfdgfdagdagsgfsdgdfgsgfdgfdgfsdgsfvg" + name);
            int result = 0;
            try
            {
                // TODO: Call Init()
                Init();

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Molimo unesite validno ime!?");
                else if (string.IsNullOrEmpty(location))
                    throw new Exception("Molimo unesite validnu lokaciju!?");
                else if (string.IsNullOrEmpty(imageUrl))
                    throw new Exception("Molimo unesite validan url!?");
                else if (double.IsNaN(price))
                    throw new Exception("Molimo unesite validnu cijenu!?");

                // TODO: Insert the new person into the database
                result = conn.Insert(new ReservationModel { Name = name, Location = location, ImageUrl = imageUrl, Price = price });

                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, name, location, imageUrl, price);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", name, ex.Message);
            }

        }

    //    public List<ReservationModel> GetAllReservations()
    //    {
    //        try
    //        {
    //            Init();
    //            return conn.Table<ReservationModel>().ToList();
    //        }
    //        catch (Exception ex)
    //        {
    //            StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
    //        }

    //        return new List<ReservationModel>();
    //    }

    }
}

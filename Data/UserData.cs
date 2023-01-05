using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trailfinders.Models;

namespace Trailfinders.Data
{
    public class UserData
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<UserData> Instance =
           new AsyncLazy<UserData>(async () =>
           {
               var instance = new UserData();
               try
               {
                   CreateTableResult result = await Database.CreateTableAsync<User>();
               }
               catch (Exception ex)
               {

                   throw;
               }
               return instance;
           });


        public UserData()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<User>> GetItemsAsync()
        {
            return Database.Table<User>().ToListAsync();
        }

        public Task<List<User>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<User>("SELECT * FROM [User] WHERE [Done] = 0");
        }

        public Task<User> GetItemAsync(int id)
        {
            return Database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(User _user)
        {
            if (_user.ID != 0)
            {
                return Database.UpdateAsync(_user);
            }
            else
            {
                return Database.InsertAsync(_user);
            }
        }

    }
}

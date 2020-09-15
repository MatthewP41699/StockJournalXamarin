using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace CrossPlat
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Stock>().Wait();
        }

        public Task<List<Stock>> GetPeopleAsync()
        {
            return _database.Table<Stock>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Stock stock)
        {
            return _database.InsertAsync(stock);
        }
    }
}

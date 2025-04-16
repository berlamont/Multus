using SQLite;

namespace Multus.Database
{
    public class MultusDb
    {
        SQLiteAsyncConnection _database;

        async Task Init()
        {
            if (_database is not null)
                return;

            _database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

            // Dynamically create tables for all types
            await _database.CreateTableAsync<TodoItem>();
            await _database.CreateTableAsync<NoteItem>();
        }

        public async Task<List<T>> GetItemsAsync<T>() where T : new()
        {
            await Init();
            return await _database.Table<T>().ToListAsync();
        }

        public async Task<T> GetItemAsync<T>(int id) where T : new()
        {
            await Init();
            return await _database.FindAsync<T>(id);
        }

        public async Task<int> SaveItemAsync<T>(T item) where T : new()
        {
            await Init();
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && (int)idProperty.GetValue(item) != 0)
                return await _database.UpdateAsync(item);
            return await _database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync<T>(T item) where T : new()
        {
            await Init();
            return await _database.DeleteAsync(item);
        }
    }
}

using SQLite;

namespace Multus.Database
{
    public abstract class MultusDb
    {
        SQLiteAsyncConnection database;

        async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

            // Dynamically create tables for all types
            await database.CreateTableAsync<TodoItem>();
            await database.CreateTableAsync<NoteItem>();
        }

        public async Task<List<T>> GetItemsAsync<T>() where T : new()
        {
            await Init();
            return await database.Table<T>().ToListAsync();
        }

        public async Task<T> GetItemAsync<T>(int id) where T : new()
        {
            await Init();
            return await database.FindAsync<T>(id);
        }

        public async Task<int> SaveItemAsync<T>(T item) where T : new()
        {
            await Init();
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null && (int)idProperty.GetValue(item) != 0)
                return await database.UpdateAsync(item);
            return await database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync<T>(T item) where T : new()
        {
            await Init();
            return await database.DeleteAsync(item);
        }
    }
}

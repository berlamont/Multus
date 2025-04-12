using SQLite;

namespace Multus.Database
{
    public class MultusDb
    {
        SQLiteAsyncConnection database;

        async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await database.CreateTableAsync<TodoItem>();
            await database.CreateTableAsync<NoteItem>();
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            await Init();
            return await database.Table<TodoItem>().ToListAsync();
        }

        public async Task<List<TodoItem>> GetTodoItemsNotDoneAsync()
        {
            await Init();
            return await database.Table<TodoItem>().Where(t => t.Done).ToListAsync();

            // SQL queries are also possible
            //return await database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public async Task<TodoItem> GetTodoItemAsync(int id)
        {
            await Init();
            return await database.Table<TodoItem>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveTodoItemAsync(TodoItem item)
        {
            await Init();
            if (item.Id != 0)
            {
                return await database.UpdateAsync(item);
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }

        public async Task<int> DeleteTodoItemAsync(TodoItem item)
        {
            await Init();
            return await database.DeleteAsync(item);
        }
    }
}

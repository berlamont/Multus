using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multus.Models;
using SQLite;

namespace Multus.Data
{
    public class NotesDatabase
    {
        public NotesDatabase()
        {
        }

        SQLiteAsyncConnection _database;

        async Task Init()
        {
            if (_database is not null)
                return;

            _database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await _database.CreateTableAsync<NoteItem>();
        }

        public async Task<List<NoteItem>> GetItemsAsync()
        {
            await Init();
            return await _database.Table<NoteItem>().ToListAsync();
        }

        public async Task<List<NoteItem>> GetItemsNotDoneAsync()
        {
            await Init();
            return await _database.Table<NoteItem>().Where(t => t.Done).ToListAsync();

            // SQL queries are also possible
            //return await Database.QueryAsync<NoteItem>("SELECT * FROM [NoteItem] WHERE [Done] = 0");
        }

        public async Task<NoteItem> GetItemAsync(int id)
        {
            await Init();
            return await _database.Table<NoteItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(NoteItem item)
        {
            await Init();
            if (item.ID != 0)
            {
                return await _database.UpdateAsync(item);
            }
            else
            {
                return await _database.InsertAsync(item);
            }
        }

        public async Task<int> DeleteItemAsync(NoteItem item)
        {
            await Init();
            return await _database.DeleteAsync(item);
        }
    }
}
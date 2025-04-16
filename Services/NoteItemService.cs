using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multus.Database;

namespace Multus.Services
{
    public class NoteItemService(MultusDb db) : ItemService
    {
        readonly MultusDb _db = db;

        public override async Task<IEnumerable<Item>> GetItems()
        {
            var items = await _db.GetItemsAsync<NoteItem>();
            return items.ToList();
        }

        public override async Task<Item> GetItem(int id)
        {
            var item = await _db.GetItemAsync<NoteItem>(id);
            return item;
        }
    }
}

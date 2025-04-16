using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multus.Services
{
    public abstract class ItemService
    {
        public virtual Task<IEnumerable<Item>> GetItems()
        {
            // This method should be overridden in derived classes to provide the actual implementation
            throw new NotImplementedException("GetItems method must be implemented in derived classes.");

        }

        public abstract Task<Item> GetItem(int id);
    }
}

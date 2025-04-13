using SQLite;

namespace Multus.Models
{
    public abstract class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}

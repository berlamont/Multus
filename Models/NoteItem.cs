using SQLite;

namespace Multus.Models
{
    public class NoteItem
    {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Name { get; set; }
            public string Note { get; set; }
            public DateTime? Entered { get; set; }
            public bool Done { get; set; }
    }
}

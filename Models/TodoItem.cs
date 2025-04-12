using SQLite;

namespace Multus.Models
{
    public class TodoItem : Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }

        public enum Category
        {
            WantToDo,
            Doing,
            Done,
        }
        public enum Priority
        {
            Low,
            Medium,
            High,
        }


        public DateTime Date { get; set; }
        public bool Done { get; set; }
    }
}

using SQLite;

namespace Multus.Models
{
    public class TodoItem : Item
    {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multus.Models
{
    public class NoteItem : Item
    {
        /// <summary>
        /// seems redundant, yes, but you know damn well you will treat note items as having details and not descriptions like td items because brain is wired that way apparently
        /// </summary>
        public string? Details { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

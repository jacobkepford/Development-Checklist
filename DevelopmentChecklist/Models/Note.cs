using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentChecklist.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public string NoteText { get; set; }
        public int NoteAuthorID { get; set; }
        public DateTime NoteDate { get; set; }
    }
}

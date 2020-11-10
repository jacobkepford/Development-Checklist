using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentChecklist.Models
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        public int AppID { get; set; }
        public string NoteText { get; set; }
        public int DeveloperID { get; set; }
        public DateTime NoteDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentChecklist.Models
{
    public class AppAssignment
    {
        [Key]
        public int AssignmentID { get; set; }
        public int AppID { get; set; }
        public int DeveloperID { get; set; }
    }
}

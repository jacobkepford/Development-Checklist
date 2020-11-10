using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentChecklist.Models
{
    public class Developer
    {
        [Key]
        public int DeveloperID { get; set; }
        public string DeveloperFirstName { get; set; }
        public string DeveloperLastName { get; set; }
    }
}

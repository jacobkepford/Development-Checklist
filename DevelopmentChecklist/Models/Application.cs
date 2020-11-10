using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentChecklist.Models
{
    public enum Status
    {
        InDevelopment, WorkInProgress, Testing, Live  
    }
    
    public class Application
    {
        public int AppID { get; set; }
        public string AppName { get; set; }
        public string AppURL { get; set; }
        public string AppDescription { get; set; }
        public ICollection<Developer>Developers { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

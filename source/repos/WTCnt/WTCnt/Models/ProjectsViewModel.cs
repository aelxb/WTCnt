using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class ProjectsViewModel
    {
        public IEnumerable<Usr> Users { get; set; }
        public IEnumerable<Prject> Prjects { get; set; }
        public Prject Prject { get; set; }
        public List<ProjectPerTask> ProjectPerTasks {get;set;}
        public List<Task> tasks { get; set; }
        public IEnumerable<Message> messages { get; set; }
        public string messText { get; set; }
    }
}

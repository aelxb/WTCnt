using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class LKModel
    {
        public List<Task> Tasks { get; set; }
        public Usr User { get; set; }
        public List<Prject> Projects { get; set; }
        public List<ProjectPerTask> ProjectPerUsers {get;set;}
        public List<Usr> Users { get; set; }
    }
}

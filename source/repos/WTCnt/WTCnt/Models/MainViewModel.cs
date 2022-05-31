using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class MainViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public Task Task { get; set; }
        public bool IsActiveTaskExists { get; set; }
        public string Sort { get; set; }
        public IEnumerable<Usr> Users { get; set; }
    }
}
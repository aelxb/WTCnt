using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class PpUViewModel
    {
        public IEnumerable<Usr> Users { get; set; }
        public int ProjectID { get; set; }
        public ProjectPerTask ProjectPerUser { get; set; }
        public Task Task { get; set; }
    }
}

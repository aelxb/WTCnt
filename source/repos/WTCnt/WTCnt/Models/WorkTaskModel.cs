using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class WorkTaskModel
    {
        public List<Usr> Users { get; set; }
        public Task Task { get; set; }
    }
}

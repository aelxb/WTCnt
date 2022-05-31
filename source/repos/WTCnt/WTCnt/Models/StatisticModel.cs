using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class StatisticModel
    {
        public List<Task> Tasks { get; set; }
        public bool work { get; set; }
        public bool rest { get; set; }
        public int month { get; set; }
    }
}

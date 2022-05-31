using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class Task
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public int UserOwner { get; set; }
        public int Done { get; set; }
    }
}

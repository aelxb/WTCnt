﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

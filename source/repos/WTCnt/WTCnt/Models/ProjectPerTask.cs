using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class ProjectPerTask
    {
        public int ID_project { get; set; }
        public int ID_Task { get; set; }
    }

}
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WTCnt.Models;

namespace WTCnt.Controllers
{
    public class StatisticController : Controller
    {
        private readonly TaskContext _context;
        public StatisticController(TaskContext context)
        {
            _context = context;
        }
        public IActionResult TasksStatistic()
        {
            var Model = _context.Task;
            int i = Model.ToList().FindAll(t => t.Type == "Отгул").Count;// != 0 ? (Model.Count() / Model.ToList().FindAll(t => t.Type == "Отгул").Count * 100) : 0;
            int y = Model.ToList().FindAll(t => t.Type == "Болезнь").Count;// != 0 ? (Model.Count() / Model.ToList().FindAll(t => t.Type == "Болезнь").Count * 100) : 0;
            int z = Model.ToList().FindAll(t => t.Type == "Отпуск").Count;// != 0 ? (Model.Count() / Model.ToList().FindAll(t => t.Type == "Отпуск").Count * 100) : 0;
            int e = Model.ToList().FindAll(t => t.Type == "Другое").Count;// != 0 ? (Model.Count() / Model.ToList().FindAll(t => t.Type == "Другое").Count * 100) : 0;
            List<int> tasks = new List<int>{i,y,z,e};
            return View(tasks);
        }
    }
}

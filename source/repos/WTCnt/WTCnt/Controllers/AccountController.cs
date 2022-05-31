using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WTCnt.Models;
using Task = System.Threading.Tasks.Task;
using System.IO;
using System.Xml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using ServiceStack.Host;
using Microsoft.AspNetCore.Http;

namespace WTCnt.Controllers
{
    public class AccountController : Controller
    {
        private UsrContext _context;
        private TaskContext _tcontext;
        private PrjectContext _pcontext;
        private ProjectPerTaskContext _ppucontext;

        public AccountController(UsrContext context, TaskContext tcontext, PrjectContext pcontext, ProjectPerTaskContext ppucontext)
        {
            _context = context;
            _tcontext = tcontext;
            _pcontext = pcontext;
            _ppucontext = ppucontext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Usr user = _context.User.ToList().Find(u => u.DomenName == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        private async Task Authenticate(Usr user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.ID.ToString()),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [HttpPost]
        public async Task<IActionResult> Logout(LoginModel model)
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> FilterStatistic(bool work, bool rest, int month)
        {
            StatisticModel model = new StatisticModel();
            List<Models.Task> list = null;
            try
            {
                if (work && !rest)
                    list = _tcontext.Task.ToList().FindAll(x => x.Type == "Работа" && x.CreationDate.Month == month && x.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
                else if (rest && !work)
                    list = _tcontext.Task.ToList().FindAll(x => x.Type != "Работа" && x.CreationDate.Month == month && x.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
                else
                    list = _tcontext.Task.ToList().FindAll(x => x.CreationDate.Month == month && x.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
            }
            catch { }
            model.Tasks = list;
            model.month = month;
            model.rest = rest;
            model.work = work;
            return View(model);
        }
        [HttpGet]
        public IActionResult LK()
        {
            LKModel model = new LKModel();
            model.Tasks = _tcontext.Task.ToList();//.FindAll(t => t.Type != "Работа" && t.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
            model.Users = _context.User.ToList();
            model.User = _context.User.ToList().Find(u => u.ID == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
            model.Projects = _pcontext.Project.ToList();
            //model.ProjectPerUsers = _ppucontext.ProjectPerUsers.ToList().FindAll(ppu => ppu.ID_Task == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
            return View(model);
        }
        [HttpGet]
        public IActionResult PersonalStatistic()
        {
            StatisticModel model = new StatisticModel();
            model.Tasks = _tcontext.Task.ToList().FindAll(t => t.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name)&&t.CreationDate.Month==DateTime.Now.Month);
            model.rest = true;
            model.work = true;
            return View(model);
        }
        [HttpGet]
        public IActionResult EmployeeStatistic(int? id)
        {
            StatisticModel model = new StatisticModel();
            model.Tasks = _tcontext.Task.ToList().FindAll(t => t.UserOwner == (int)id && t.CreationDate.Month == DateTime.Now.Month);
            model.rest = true;
            model.work = true;
            return View(model);
        }
        [HttpGet]
        public IActionResult Exc()
        {
            byte[] file = Excl();
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }
        public byte[] Excl()
        {
            System.IO.File.Copy(@"C:\Users\alexb\source\repos\WTCnt\WTCnt\wwwroot\files\kml.xlsx", @"C:\Users\alexb\source\repos\WTCnt\WTCnt\wwwroot\files\res.xlsx", true);
            using (SpreadsheetDocument myWorkbook = SpreadsheetDocument.Open(@"C:\Users\alexb\source\repos\WTCnt\WTCnt\wwwroot\files\res.xlsx", true))
            {
                WorkbookPart workbookPart = myWorkbook.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.ElementAt(0);
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                int index = 2;
                var query = _tcontext.Task;
                sheetData.AppendChild(SetRow("Задача/комментарий", 1, "A"));
                sheetData.AppendChild(SetRow("Дата создания", 1, "B"));
                sheetData.AppendChild(SetRow("Окончено", 1, "C"));
                sheetData.AppendChild(SetRow("Дата окончания", 1, "D"));
                sheetData.AppendChild(SetRow("Тип", 1, "E"));
                foreach (var item in query)
                {
                    sheetData.AppendChild(SetRow(item.Comment, index, "A"));
                    sheetData.AppendChild(SetRow(item.CreationDate.ToString("d"), index, "B"));
                    sheetData.AppendChild(SetRow((item.Done == 2) ? "Завершена" : "Не завершена", index, "C"));
                    sheetData.AppendChild(SetRow((item.EndDate != null) ? item.EndDate.Value.ToString("d") : "", index, "D"));
                    sheetData.AppendChild(SetRow(item.Type, index, "E"));
                    index++;
                }
                worksheetPart.Worksheet.Save();
            }
            return System.IO.File.ReadAllBytes(@"C:\Users\alexb\source\repos\WTCnt\WTCnt\wwwroot\files\res.xlsx");
        }
        public Row SetRow(string Nom, int index, string cl)
        {
            Row row = new Row();
            row.RowIndex = (UInt32)index;
            Cell cell = new Cell();
            cell.DataType = CellValues.InlineString;
            cell.CellReference = cl + index;
            Text t = new Text();
            t.Text = Nom;
            InlineString inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);
            return row;
        }
    }
}

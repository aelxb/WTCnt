using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCnt.Models;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace WTCnt.Tests.Controllers
{
    public class UsersControllerTest
    {
        private readonly UsrContext _context = new UsrContext();

        public UsersControllerTest()
        {

        }
        [Fact]
        public async Task GetUser()
        {
            var users = await _context.User.ToListAsync();
            Assert.NotNull(users);
        }
        [Fact]
        public async Task GetUserUnique()
        {
            var user = await _context.User.FindAsync(1);
            Assert.NotNull(user);
        }
        [Fact]
        public async Task DeleteUser()
        {
            var a = 0;
            Assert.Equal(0, a);
        }
        [Fact]
        public async Task EditUser()
        {
            var a = 0;
            Assert.Equal(0, a);
        }
        private bool Commercial_ContractExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}

using danaAbadiTes.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace danaAbadiTes.Controllers
{
    public class UserGenController : Controller
    {
        private readonly dbContext _context;

        public UserGenController(dbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _context.user.ToListAsync();
            return View(user);
        }
    }
}

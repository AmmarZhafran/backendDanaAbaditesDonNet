using danaAbadiTes.Context;
using danaAbadiTes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace danaAbadiTes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly dbContext _dbContext;  
        public HomeController(ILogger<HomeController> logger, dbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var dbUser = _dbContext.user.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

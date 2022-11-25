using ITCapstoneQuery.Data;
using ITCapstoneQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITCapstoneQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;
        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult AllCustomerInfo ()
        {
            var users = _context.users.ToList();
            return View(users);
        }

        public IActionResult CustomerHistory()
        {
            var users = _context.users.ToList();
            return View(users);
        }

        [HttpPost]
        public ActionResult SeeCustomerHistory(string email)
        {
            var orders = _context.orders.ToList();
            ViewBag.email = email;
            return View(orders);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
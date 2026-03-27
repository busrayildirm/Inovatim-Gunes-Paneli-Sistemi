using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using güneşpaneli.Models;

namespace güneşpaneli.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Ana Sayfa
        public IActionResult Index()
        {
            return View();
        }

        // Hakkımızda Sayfası
        public IActionResult About()
        {
            return View();
        }

        // İletişim Sayfası
        public IActionResult Contact()
        {
            return View();
        }

        // Privacy sayfası (isteğe bağlı)
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
     
       }
        // Hesaplama Sayfası
        public IActionResult Calculator()
        {
            return View();
        }

    }
}

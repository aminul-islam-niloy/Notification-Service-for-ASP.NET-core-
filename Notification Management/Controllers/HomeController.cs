using Microsoft.AspNetCore.Mvc;
using Notification_Management.Models;
using Notification_Management.Services;
using System.Diagnostics;

namespace Notification_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly NotificationService _notificationService;

        public HomeController(ILogger<HomeController> logger, NotificationService notificationService)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        public IActionResult Index()
        {
       
            _notificationService.AddNotification(" test notification.");
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
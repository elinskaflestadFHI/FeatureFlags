using FeatureFlags.FeatureFlags;
using FeatureFlags.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FeatureFlags.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFeatureFlagHandler _featureFlagHandler;

        public HomeController(ILogger<HomeController> logger, IFeatureFlagHandler featureFlagHandler)
        {
            _logger = logger;
            _featureFlagHandler = featureFlagHandler;
        }

        public IActionResult Index()
        {
            ViewBag.ShowLogo = _featureFlagHandler.IsEnabled("ShowLogo", "gaute", false);

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
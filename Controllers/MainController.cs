using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZyzzGymOriginal.Models;
using ZyzzGymOriginal.Services;

namespace ZyzzGymOriginal.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        private readonly IMainAnnouncementsViewModelProvider _mainAnnouncementsViewModelProvider;
        private readonly IMainPricingViewModelProvider _mainPricingViewModelProvider;
        public MainController(ILogger<MainController> logger, IMainAnnouncementsViewModelProvider mainAnnouncementsViewModelProvider, IMainPricingViewModelProvider mainPricingViewModelProvider)
        {
            _logger = logger;
            _mainAnnouncementsViewModelProvider = mainAnnouncementsViewModelProvider;
            _mainPricingViewModelProvider = mainPricingViewModelProvider;
        }

        public IActionResult Announcements()
        {
            var viewModel = _mainAnnouncementsViewModelProvider.PrepareAnnouncementsViewModel();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            var viewModel = _mainPricingViewModelProvider.PreparePricingViewModel();
            return View(viewModel);
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Contact()
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
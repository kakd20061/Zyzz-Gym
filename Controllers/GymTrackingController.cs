using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models.Dtos;
using ZyzzGymOriginal.Services;

namespace ZyzzGymOriginal.Controllers
{
    public class GymTrackingController : Controller
    {
        private readonly SignInManager<NewIdentityUser> _SignInManager;
        private readonly UserManager<NewIdentityUser> _UserManager;
        private readonly IAchivementsViewModelProvider _achievementsViewModelProvider;
        private readonly IAchievementsRepository _achivementsRepository;
        private readonly ApplicationDbContext _dbContext;
        public GymTrackingController(SignInManager<NewIdentityUser> SignInManager, UserManager<NewIdentityUser> UserManager, IAchivementsViewModelProvider achievementsViewModelProvider, IAchievementsRepository achivementsRepository, ApplicationDbContext dbContext)
        {
            _SignInManager = SignInManager;
            _UserManager = UserManager;
            _achievementsViewModelProvider = achievementsViewModelProvider;
            _achivementsRepository = achivementsRepository;
            _dbContext = dbContext;
        }
        public IActionResult Achievements()
        {
            if(_SignInManager.IsSignedIn(User))
            {
                var userName = User.Identity.Name;
                var user = _dbContext.Users.FirstOrDefault(n => n.UserName == userName);
                var viewModel = _achievementsViewModelProvider.PrepareAchievementViewModel(user.Id);
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult addRequest(RequestDto formData2)
        {
            if (_SignInManager.IsSignedIn(User))
            {
                var modelValidated = _achievementsViewModelProvider.ValidateRequest(formData2, ModelState);
                if (modelValidated)
                {
                    var viewModel = _achievementsViewModelProvider.AddRequest(formData2);
                    return RedirectToAction("Achievements", "GymTracking");
                }
                return RedirectToAction("Achievements", "GymTracking");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Add(AchievementDto formData)
        {
            if (_SignInManager.IsSignedIn(User))
            {

                var userName = User.Identity.Name;
                var user = _dbContext.Users.FirstOrDefault(n => n.UserName == userName);
                string UserForeignKey = user.Id;

                var modelValidated = _achievementsViewModelProvider.Validate(formData, ModelState);
                if (modelValidated)
                {
                    var viewModel = _achievementsViewModelProvider.AddAchievements(formData, UserForeignKey);
                    return RedirectToAction("Achievements", "GymTracking");
                }

                return RedirectToAction("Achievements", "GymTracking");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Remove(int Id)
        {
            if (_SignInManager.IsSignedIn(User))
            {
                var viewModel = _achievementsViewModelProvider.DeleteAchievements(Id);
                return RedirectToAction("Achievements", "GymTracking");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Statistics()
        {
            var viewModel = _achievementsViewModelProvider.PrepareStatisticsViewModel();
            return View(viewModel);
        }
    }
}

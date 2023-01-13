using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models.Dtos;
using ZyzzGymOriginal.Services;

namespace ZyzzGymOriginal.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly SignInManager<NewIdentityUser> _SignInManager;
        private readonly UserManager<NewIdentityUser> _UserManager;
        private readonly IMainAnnouncementsViewModelProvider _mainAnnouncementsViewModelProvider;
        private readonly IMainPricingViewModelProvider _mainPricingViewModelProvider;
        private readonly IAchivementsViewModelProvider _AchievementsViewModelProvider;
        private readonly IAdministrationViewModelProvider _administrationViewModelProvider;


        public AdministrationController(SignInManager<NewIdentityUser> SignInManager, UserManager<NewIdentityUser> UserManager, IMainAnnouncementsViewModelProvider mainAnnouncementsViewModelProvider, IMainPricingViewModelProvider mainPricingViewModelProvider, IAchivementsViewModelProvider AchievementsViewModelProvider, IAdministrationViewModelProvider administrationViewModelProvider)
        {
            _SignInManager = SignInManager;
            _UserManager = UserManager;
            _mainAnnouncementsViewModelProvider = mainAnnouncementsViewModelProvider;
            _mainPricingViewModelProvider = mainPricingViewModelProvider;
            _AchievementsViewModelProvider = AchievementsViewModelProvider;
            _administrationViewModelProvider = administrationViewModelProvider;

        }
        public IActionResult AdminPanel()
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name=="gizard.biznes123@vp.pl")
            {
                var viewModel = _administrationViewModelProvider.PrepareAdminViewModel();
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Decline(int Id)
        {

            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {

                var viewModel = _administrationViewModelProvider.Decline(Id);
                return RedirectToAction("Requests", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Accept(int Id)
        {

            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {

                var viewModel = _administrationViewModelProvider.Accept(Id);
                return RedirectToAction("Requests", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Requests()
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _administrationViewModelProvider.PrepareRequestsViewModel();
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult AnnouncementsEdit()
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _mainAnnouncementsViewModelProvider.PrepareAnnouncementsAdminViewModel();
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult ExerciseEdit()
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _AchievementsViewModelProvider.PrepareExerciseAdminViewModel();
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult editChanges(AnnouncementsDto formData)
        {
            var modelValidated = _mainAnnouncementsViewModelProvider.ValidateCreate(formData, ModelState);
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                if (modelValidated)
                {
                    var viewModel = _mainAnnouncementsViewModelProvider.Edit(formData);
                    return RedirectToAction("AnnouncementsEdit", "Administration");
                }

                return RedirectToAction("AnnouncementsEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Add(AnnouncementsDto formData)
        {
            var modelValidated = _mainAnnouncementsViewModelProvider.ValidateCreate(formData, ModelState);
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                if (modelValidated)
                {
                    var viewModel = _mainAnnouncementsViewModelProvider.Add(formData);
                    return RedirectToAction("AnnouncementsEdit", "Administration");
                }

                return RedirectToAction("AnnouncementsEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult Delete(AnnouncementsDto formData)
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _mainAnnouncementsViewModelProvider.Delete(formData.Id);
                return RedirectToAction("AnnouncementsEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult editPrices(PricingDto formData)
        {
            var modelValidated = _mainPricingViewModelProvider.ValidateCreate(formData, ModelState);

            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                if (modelValidated)
                {
                    var viewModel = _mainPricingViewModelProvider.Edit(formData);
                    return RedirectToAction("PricingEdit", "Administration");
                }

                return RedirectToAction("PricingEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult addPrice(PricingDto formData)
        {
            var modelValidated = _mainPricingViewModelProvider.ValidateCreate(formData,ModelState);
            
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                if (modelValidated)
                {
                    var viewModel = _mainPricingViewModelProvider.Add(formData);
                    return RedirectToAction("PricingEdit", "Administration");
                }
                
                return RedirectToAction("PricingEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult deletePrice(PricingDto formData)
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _mainPricingViewModelProvider.Delete(formData.Id);
                return RedirectToAction("PricingEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult exerciseAdd(ExerciseNameDto formData)
        {

            var modelValidated = _AchievementsViewModelProvider.ValidateCreate(formData, ModelState);
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                if (modelValidated)
                {
                    var viewModel = _AchievementsViewModelProvider.Add(formData);
                    return RedirectToAction("ExerciseEdit", "Administration");
                }
                return RedirectToAction("ExerciseEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult editExercise(ExerciseNameDto formData)
        {
            var modelValidated = _AchievementsViewModelProvider.ValidateCreate(formData, ModelState);
            Console.WriteLine(modelValidated);
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
               if (modelValidated)
               {
                    var viewModel = _AchievementsViewModelProvider.Edit(formData);
                    return RedirectToAction("ExerciseEdit", "Administration");
               }
               return RedirectToAction("ExerciseEdit", "Administration");
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        public IActionResult PricingEdit()
        {
            if (_SignInManager.IsSignedIn(User) && User.Identity?.Name == "gizard.biznes123@vp.pl")
            {
                var viewModel = _mainPricingViewModelProvider.PreparePricingAdminViewModel();
                return View(viewModel);
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }
    }
}

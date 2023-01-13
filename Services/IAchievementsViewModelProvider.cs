using Microsoft.AspNetCore.Mvc.ModelBinding;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Services
{
    public interface IAchivementsViewModelProvider
    {
        GymTrackingAchievementsVm PrepareAchievementViewModel(string Id);
        AdministrationExerciseEditVm PrepareExerciseAdminViewModel();
        GymTrackingStatisticsVm PrepareStatisticsViewModel();
        bool ValidateCreate(ExerciseNameDto model, ModelStateDictionary modelState);
        bool Validate(AchievementDto model, ModelStateDictionary modelState);
        bool ValidateRequest(RequestDto model, ModelStateDictionary modelState);

        bool AddAchievements(AchievementDto model,string UserId);
        bool DeleteAchievements(int Id);
        bool Add(ExerciseNameDto model);
        bool Edit(ExerciseNameDto model);

        bool AddRequest(RequestDto model);
    }

    public class AchievementsViewModelProvider : IAchivementsViewModelProvider
    {
        private readonly IAchievementsRepository _achievementsRepository;
        private readonly IExerciseNameRepository _exerciseNameRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRequestRepository _requestRepository;

        public AchievementsViewModelProvider(IAchievementsRepository achievementsRepository, IExerciseNameRepository exerciseNameRepository, IUserRepository userRepository, IRequestRepository requestRepository)
        {
            _achievementsRepository = achievementsRepository;
            _exerciseNameRepository = exerciseNameRepository;
            _userRepository = userRepository;
            _requestRepository = requestRepository;
        }

        public GymTrackingAchievementsVm PrepareAchievementViewModel(string Id)
        {
            var exercises = _exerciseNameRepository.All();
            var procesed = exercises.Select(n => new ExerciseNameDto(n)).ToList();            
            var achievements = _achievementsRepository.All(Id);
            var procesed2 = achievements.Select(n => new AchievementDto(n)).ToList();
            var user = _userRepository.All();
            var procesed3 = user.Select(n => new NewIdentityUser()).ToList();

            return new GymTrackingAchievementsVm()
            {
                ExerciseName = procesed,
                Achievements = procesed2,
                User = procesed3
            };

        }

        public GymTrackingStatisticsVm PrepareStatisticsViewModel()
        {
            var exercises = _exerciseNameRepository.All();
            var procesed = exercises.Select(n => new ExerciseNameDto(n)).ToList();
            var achievements = _achievementsRepository.All2();
            var procesed2 = achievements.Select(n => new AchievementDto(n)).ToList();
            var Max = _achievementsRepository.Max();



            return new GymTrackingStatisticsVm()
            {
                ExerciseName = procesed,
                Achievements = procesed2,
                Max = Max,
            };

        }

        public AdministrationExerciseEditVm PrepareExerciseAdminViewModel()
        {
            var exercises = _exerciseNameRepository.All();
            var procesed = exercises.Select(n => new ExerciseNameDto(n)).ToList();


            return new AdministrationExerciseEditVm()
            {
                exerciseName = procesed

            };

        }

        public bool ValidateCreate(ExerciseNameDto model, ModelStateDictionary modelState)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                modelState.AddModelError(nameof(model.Name), "Name can't be empty!");
            }

            return modelState.IsValid;
        }

        public bool ValidateRequest(RequestDto model, ModelStateDictionary modelState)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                modelState.AddModelError(nameof(model.Name), "Name can't be empty!");
            }

            return modelState.IsValid;
        }

        public bool Validate(AchievementDto model, ModelStateDictionary modelState)
        {
            foreach (var m in modelState.Values)
            {
                foreach (ModelError error in m.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                    // Get the Error details.
                }
            }
            if (string.IsNullOrEmpty(model.ExerciseForeignKey.ToString()))
            {
                modelState.AddModelError(nameof(model.ExerciseForeignKey), "Exercise can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Reps.ToString()))
            {
                modelState.AddModelError(nameof(model.ExerciseForeignKey), "Reps can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Weight.ToString()))
            {
                modelState.AddModelError(nameof(model.ExerciseForeignKey), "Weight can't be empty!");
            }

            return modelState.IsValid;
        }

        public bool AddAchievements(AchievementDto model,string UserId)
        {
            var entity = model.ParseToEntity(UserId);
            _achievementsRepository.Add(entity);
            return true;
        }

        public bool DeleteAchievements(int Id)
        {
            _achievementsRepository.Delete(Id);
            return true;
        }

        public bool Add(ExerciseNameDto model)
        {
            var entity = model.ParseToEntity();
            _exerciseNameRepository.Add(entity);
            return true;
        }
        public bool Edit(ExerciseNameDto model)
        {
            var entity = model.ParseToEntity();
            _exerciseNameRepository.Edit(entity);
            return true;
        }

        public bool AddRequest(RequestDto model)
        {
            var entity = model.ParseToEntity();
            _requestRepository.Add(entity);
            return true;
        }
    }
}


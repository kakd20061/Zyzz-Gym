using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Services
{
    public interface IAdministrationViewModelProvider
    {
        AdministrationAdminPanelVm PrepareAdminViewModel();
        AdministrationRequestsVm PrepareRequestsViewModel();

        bool Accept(int Id);

        bool Decline(int Id);

        int Count();

    }

    public class AdministrationAdminPanelViewModelProvider : IAdministrationViewModelProvider
    {
        private readonly IAnnouncementsRepository _announcementsRepository;
        private readonly IPricingRepository _pricingRepository;
        private readonly IExerciseNameRepository _exerciseNameRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRequestRepository _requestRepository;
        private readonly IAchievementsRepository _achievementsRepository;

        public AdministrationAdminPanelViewModelProvider(IAnnouncementsRepository announcementsRepository, IPricingRepository pricingRepository, IExerciseNameRepository exerciseNameRepository, IUserRepository userRepository, IRequestRepository requestRepository, IAchievementsRepository achievementsRepository)
        {
            _announcementsRepository = announcementsRepository;
            _pricingRepository = pricingRepository;
            _exerciseNameRepository = exerciseNameRepository;
            _userRepository = userRepository;
            _requestRepository = requestRepository;
            _achievementsRepository = achievementsRepository;
        }

        AdministrationAdminPanelVm IAdministrationViewModelProvider.PrepareAdminViewModel()
        {
            var exercises = _exerciseNameRepository.Count();
            var pricing = _pricingRepository.Count();
            var announcements = _announcementsRepository.Count();
            var users = _userRepository.Count();
            var requests = _requestRepository.Count();
            var achievements = _achievementsRepository.Count();
            return new AdministrationAdminPanelVm()
            {
                MemebershipCount = pricing,
                AnnouncementCount = announcements,
                ExerciseCount = exercises,
                UserCount = users,
                RequestCount = requests,
                AchievementsCount = achievements
            };
        }
        AdministrationRequestsVm IAdministrationViewModelProvider.PrepareRequestsViewModel()
        {
            var requests = _requestRepository.All();
            var procesed = requests.Select(n => new RequestDto(n)).ToList();
            var count = _requestRepository.Count();
            return new AdministrationRequestsVm()
            {
                Requests = procesed,
                Count = count
            };
        }

        public bool Accept(int Id)
        {
            var ent = _requestRepository.One(Id);
            var model = new RequestDto
            {
                Name = ent.ExerciseName
            };
            var entityProcesed = model.ParseToExerciseName();
            _exerciseNameRepository.Add(entityProcesed);
            _requestRepository.Delete(Id);

            return true;
        }

        public bool Decline(int Id)
        {
            _requestRepository.Delete(Id);
            return true;
        }

        public int Count()
        {
            return _requestRepository.Count();
        }
    }
}

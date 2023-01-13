using Microsoft.AspNetCore.Mvc.ModelBinding;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Services
{
    public interface IMainAnnouncementsViewModelProvider
    {
        MainAnnouncementsVm PrepareAnnouncementsViewModel();
        AdministrationAnnouncementsEditVm PrepareAnnouncementsAdminViewModel();

        bool ValidateCreate(AnnouncementsDto model, ModelStateDictionary modelState);
        bool Edit(AnnouncementsDto model);
        bool Add(AnnouncementsDto model);
        bool Delete(int Id);
    }

    public class MainAnnouncementsViewModelProvider : IMainAnnouncementsViewModelProvider
    {
        private readonly IAnnouncementsRepository _announcementsRepository;

        public MainAnnouncementsViewModelProvider(IAnnouncementsRepository announcementsRepository)
        {
            _announcementsRepository = announcementsRepository;
        }

        public MainAnnouncementsVm PrepareAnnouncementsViewModel()
        {
            var announcements = _announcementsRepository.All();
            var procesed = announcements.Select(n => new AnnouncementsDto(n)).ToList();

            return new MainAnnouncementsVm()
            {
                Announcements = procesed
            };

        }

        AdministrationAnnouncementsEditVm IMainAnnouncementsViewModelProvider.PrepareAnnouncementsAdminViewModel()
        {
            var announcements = _announcementsRepository.All();
            var procesed = announcements.Select(n => new AnnouncementsDto(n)).ToList();

            return new AdministrationAnnouncementsEditVm()
            {
                Announcements = procesed
            };
        }

        public bool ValidateCreate(AnnouncementsDto model, ModelStateDictionary modelState)
        {
            if (string.IsNullOrEmpty(model.Title))
            {
                modelState.AddModelError(nameof(model.Title), "Title can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Description))
            {
                modelState.AddModelError(nameof(model.Description), "Description can't be empty!");
            }
            if (string.IsNullOrEmpty(model.PhotoUrl))
            {
                modelState.AddModelError(nameof(model.PhotoUrl), "Url can't be empty!");
            }
            return modelState.IsValid;
        }

        public bool Edit(AnnouncementsDto model)
        {
            var entity = model.ParseToEntity();
            _announcementsRepository.Edit(entity);
            return true;
        }

        public bool Add(AnnouncementsDto model)
        {
            var entity = model.ParseToEntity();
            _announcementsRepository.Add(entity);
            return true;
        }

        public bool Delete(int Id)
        {
            _announcementsRepository.Delete(Id);
            return true;
        }
    }
}

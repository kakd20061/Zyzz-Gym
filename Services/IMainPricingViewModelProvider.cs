using Microsoft.AspNetCore.Mvc.ModelBinding;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Models;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Services
{
    public interface IMainPricingViewModelProvider
    {
        MainPricingVm PreparePricingViewModel();

        AdministrationPricingEditVm PreparePricingAdminViewModel();
        bool ValidateCreate(PricingDto model, ModelStateDictionary modelState);

        bool Edit(PricingDto model);
        bool Add(PricingDto model);
        bool Delete(int Id);
    }

    public class MainPricingViewModelProvider : IMainPricingViewModelProvider
    {
        private readonly IPricingRepository _pricingRepository;

        public MainPricingViewModelProvider(IPricingRepository pricingRepository)
        {
            _pricingRepository = pricingRepository;
        }

        public MainPricingVm PreparePricingViewModel()
        {
            var announcements = _pricingRepository.All();
            var procesed = announcements.Select(n => new PricingDto(n)).ToList();

            return new MainPricingVm()
            {
                Pricing = procesed
            };

        }

        AdministrationPricingEditVm IMainPricingViewModelProvider.PreparePricingAdminViewModel()
        {
            var announcements = _pricingRepository.All();
            var procesed = announcements.Select(n => new PricingDto(n)).ToList();

            return new AdministrationPricingEditVm()
            {
                Pricing = procesed
            };
        }

        public bool ValidateCreate(PricingDto model, ModelStateDictionary modelState)
        {
            if(string.IsNullOrEmpty(model.PassTypeName))
            {
                modelState.AddModelError(nameof(model.PassTypeName), "Pass Name can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Price.ToString()))
            {
                modelState.AddModelError(nameof(model.Price), "Price can't be empty!");
            }
            if (string.IsNullOrEmpty(model.Description))
            {
                modelState.AddModelError(nameof(model.Description), "Description can't be empty!");
            }
            return modelState.IsValid;
        }

        public bool Edit(PricingDto model)
        {
            var entity = model.ParseToEntity();
            _pricingRepository.Edit(entity);
            return true;
        }
        public bool Add(PricingDto model)
        {
            var entity = model.ParseToEntity();
            _pricingRepository.Add(entity);
            return true;
        }
        public bool Delete(int Id)
        {
            _pricingRepository.Delete(Id);
            return true;
        }
    }
}

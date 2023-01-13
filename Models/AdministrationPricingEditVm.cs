using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class AdministrationPricingEditVm
    {
        public ICollection<PricingDto> Pricing { get; set; }
        public PricingDto formData { get; set; }
    }
}

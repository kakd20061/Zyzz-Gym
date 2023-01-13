using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class MainPricingVm
    {
        public ICollection<PricingDto> Pricing { get; set; }
    }
}

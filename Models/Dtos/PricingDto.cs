using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Models.Dtos
{
    public class PricingDto
    {
        public int Id { get; set; }
        public string PassTypeName { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public PricingDto()
        {

        }

        public PricingDto(PricingEntity entity) : base()
        {
            Id = entity.Id;
            PassTypeName = entity.PassTypeName;
            Price = entity.Price;
            Description = entity.Description;
        }

        public PricingEntity ParseToEntity()
        {
            return new PricingEntity()
            {
                Id = this.Id,
                PassTypeName = this.PassTypeName,
                Price = this.Price,
                Description = this.Description

            };
        }
    }
}

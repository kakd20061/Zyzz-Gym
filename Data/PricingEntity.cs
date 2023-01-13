namespace ZyzzGymOriginal.Data
{
    public class PricingEntity
    {
        public int Id { get; set; }

        public string PassTypeName { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public PricingEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

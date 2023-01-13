using Microsoft.EntityFrameworkCore;

namespace ZyzzGymOriginal.Data.Seeds
{
    public static class PricingSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<PricingEntity>()
                .HasData(
                    new PricingEntity()
                    {
                        Id = 1,
                        PassTypeName = "24/7 Gym Pass",
                        Price = 29.99f,
                        Description = "You can train when and how much you want!"
                    }
                );
            builder.Entity<PricingEntity>()
                .HasData(
                    new PricingEntity()
                    {
                        Id = 2,
                        PassTypeName = "Night Gym Pass",
                        Price = 14.99f,
                        Description = "You can train only at night (21:00 - 06:00)!"
                    }
                );
            builder.Entity<PricingEntity>()
                .HasData(
                    new PricingEntity()
                    {
                        Id = 3,
                        PassTypeName = "24/7 Self-renewable Gym Pass",
                        Price = 19.99f,
                        Description = "You can train when and how much you want! Money will be deducted automatically. If you choose this option, you must have a bank account."
                    }
                );
        }
    }
}

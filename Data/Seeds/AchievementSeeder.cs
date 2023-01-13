using Microsoft.EntityFrameworkCore;

namespace ZyzzGymOriginal.Data.Seeds
{
    public static class AchievementSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<AchievementsEntity>()
                .HasData(
                    new AchievementsEntity()
                    {
                        Id = 1,
                        Reps = 6,
                        Weight = 100,
                        ExerciseForeignKey = 1
                        
                    }
                );
            builder.Entity<AchievementsEntity>()
                .HasData(
                    new AchievementsEntity()
                    {
                        Id = 2,
                        Reps = 6,
                        Weight = 100,
                        ExerciseForeignKey = 2
                    }
                );
            builder.Entity<AchievementsEntity>()
                .HasData(
                    new AchievementsEntity()
                    {
                        Id = 3,
                        Reps = 6,
                        Weight = 100,
                        ExerciseForeignKey = 3
                    }
                );
        }
    }
}

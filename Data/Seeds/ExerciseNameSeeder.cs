using Microsoft.EntityFrameworkCore;

namespace ZyzzGymOriginal.Data.Seeds
{
    public class ExerciseNameSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<ExerciseNameEntity>()
                .HasData(
                    new ExerciseNameEntity()
                    {
                        Id = 1,
                        Name = "Bench Press"
                    }
                );
            builder.Entity<ExerciseNameEntity>()
                .HasData(
                    new ExerciseNameEntity()
                    {
                        Id = 2,
                        Name = "Shoulder Press"
                    }
                );
            builder.Entity<ExerciseNameEntity>()
                .HasData(
                    new ExerciseNameEntity()
                    {
                        Id = 3,
                        Name = "Squat"
                    }
                );
        }
    }
}

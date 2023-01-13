using ZyzzGymOriginal.Areas.Identity.Pages.Account;

namespace ZyzzGymOriginal.Data
{
    public class AchievementsEntity
    {
        public int Id { get; set; }

        public ExerciseNameEntity ExerciseName { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseForeignKey { get; set; }

        public NewIdentityUser User { get; set; }

        public string UserForeignKey { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public AchievementsEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

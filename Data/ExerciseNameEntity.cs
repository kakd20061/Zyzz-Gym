namespace ZyzzGymOriginal.Data
{
    public class ExerciseNameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AchievementsEntity> Achievements { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ExerciseNameEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

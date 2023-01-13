using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Models.Dtos
{
    public class AchievementDto
    {
        public int Id { get; set; }
        public int Reps { get; set; }

        public double Weight { get; set; }

        public int ExerciseForeignKey { get; set; }

        public DateTime CreatedAt { get; set; }

        public AchievementDto()
        {

        }

        public AchievementDto(AchievementsEntity entity) : base()
        {
            Id= entity.Id;
            Reps = entity.Reps;
            Weight = entity.Weight;
            ExerciseForeignKey = entity.ExerciseForeignKey;
            CreatedAt = entity.CreatedAt;
        }

        public AchievementsEntity ParseToEntity(string UserId)
        {
            return new AchievementsEntity()
            {
                Id = this.Id,
                Reps = this.Reps,
                Weight = this.Weight,
                ExerciseForeignKey = this.ExerciseForeignKey,
                CreatedAt = this.CreatedAt,
                UserForeignKey = UserId
            };
        }
    }
}


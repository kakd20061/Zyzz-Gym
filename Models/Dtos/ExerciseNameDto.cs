using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Models.Dtos
{
    public class ExerciseNameDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<AchievementDto> Achievements { get; set; }

        public ExerciseNameDto()
        {
            this.Achievements = new List<AchievementDto>();
        }

        public ExerciseNameDto(ExerciseNameEntity entity) : base()
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public ExerciseNameEntity ParseToEntity()
        {
            return new ExerciseNameEntity()
            {
                Id = this.Id,
                Name = this.Name

            };
        }
    }
}



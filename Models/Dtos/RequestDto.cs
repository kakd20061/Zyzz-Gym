using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Models.Dtos
{
    public class RequestDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public RequestDto()
        {

        }

        public RequestDto(RequestEntity entity) : base()
        {
            Id = entity.Id;
            Name = entity.ExerciseName;
            CreatedAt = DateTime.UtcNow;
        }

        public RequestEntity ParseToEntity()
        {
            return new RequestEntity()
            {
                Id=this.Id,
                ExerciseName = Name,
                CreatedAt = this.CreatedAt
            };
        }

        public ExerciseNameEntity ParseToExerciseName()
        {
            return new ExerciseNameEntity()
            {
                Name = this.Name
            };
        }
    }
}

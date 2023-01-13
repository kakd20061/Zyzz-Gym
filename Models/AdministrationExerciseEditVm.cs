using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class AdministrationExerciseEditVm
    {
        public ICollection<ExerciseNameDto> exerciseName { get; set; }
        public ExerciseNameDto formData { get; set; }
    }
}

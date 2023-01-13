using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class GymTrackingAchievementsVm
    {
        public ICollection<AchievementDto> Achievements { get; set; }
        public ICollection<ExerciseNameDto> ExerciseName { get; set; }
        public ICollection<NewIdentityUser> User { get; set; }
        public AchievementDto formData { get; set; }
        public RequestDto formData2 { get; set; }
    }
}

using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class GymTrackingStatisticsVm
    {
        public ICollection<AchievementDto> Achievements { get; set; }
        public ICollection<ExerciseNameDto> ExerciseName { get; set; }

        public List<AchievementsEntity> Max;
        //public ICollection<NewIdentityUser> User;
    }
}

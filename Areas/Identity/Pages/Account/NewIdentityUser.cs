using Microsoft.AspNetCore.Identity;
using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Areas.Identity.Pages.Account
{
    public class NewIdentityUser : IdentityUser
    {
        public ICollection<AchievementsEntity> Achievements { get; set; }
    }
}

using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class MainAnnouncementsVm
    {
        public ICollection<AnnouncementsDto> Announcements { get; set; }
    }
}

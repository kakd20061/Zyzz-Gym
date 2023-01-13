using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class AdministrationAnnouncementsEditVm
    {
        public ICollection<AnnouncementsDto> Announcements { get; set; }
        public AnnouncementsDto formData { get; set; }
    }
}

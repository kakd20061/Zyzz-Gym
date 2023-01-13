using ZyzzGymOriginal.Models.Dtos;

namespace ZyzzGymOriginal.Models
{
    public class AdministrationRequestsVm
    {
        public ICollection<RequestDto> Requests { get; set; }
        public int Count { get; set; }
        public RequestDto data { get; set; }
    }
}

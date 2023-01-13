using ZyzzGymOriginal.Data;

namespace ZyzzGymOriginal.Models.Dtos
{
    public class AnnouncementsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string PhotoUrl { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public AnnouncementsDto()
        {

        }

        public AnnouncementsDto(AnnouncementEntity entity): base()
        {
            Id= entity.Id;
            Title = entity.Title;
            PhotoUrl = entity.PhotoUrl;
            Description = entity.Description;
            CreatedAt = entity.CreatedAt;
            UpdatedAt = entity.UpdatedAt;
        }

        public AnnouncementEntity ParseToEntity()
        {
            return new AnnouncementEntity()
            {
                Id = this.Id,
                Title = this.Title,
                PhotoUrl = this.PhotoUrl,
                Description = this.Description,
                CreatedAt = this.CreatedAt,
                UpdatedAt = this.UpdatedAt
            };
        }
    }
}

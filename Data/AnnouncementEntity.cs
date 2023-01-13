namespace ZyzzGymOriginal.Data
{
    public class AnnouncementEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string PhotoUrl { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public AnnouncementEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

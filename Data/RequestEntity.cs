namespace ZyzzGymOriginal.Data
{
    public class RequestEntity
    {
        public int Id { get; set; }

        public string ExerciseName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public RequestEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

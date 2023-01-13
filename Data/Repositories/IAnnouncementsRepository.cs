namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IAnnouncementsRepository
    {
        ICollection<AnnouncementEntity> All();

        int Count();

        AnnouncementEntity One(int id);

        bool Add(AnnouncementEntity entity);

        bool Delete(int id);

        AnnouncementEntity Edit(AnnouncementEntity entity);
    }

    public class AnnouncementsRepository : IAnnouncementsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AnnouncementsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(AnnouncementEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Announcements.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<AnnouncementEntity> All()
        {
            return _dbContext.Announcements.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.Announcements.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if(entity.Title != null && entity.Title != "")
            _dbContext.Announcements.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public AnnouncementEntity Edit(AnnouncementEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Title = entity.Title;

            dbEntity.PhotoUrl = entity.PhotoUrl;

            dbEntity.Description = entity.Description;

            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Announcements.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public AnnouncementEntity One(int id)
        {
            return _dbContext.Announcements.FirstOrDefault(n => n.Id == id) ?? new AnnouncementEntity();
        }

    }

}

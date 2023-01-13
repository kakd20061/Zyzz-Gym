namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IRequestRepository
    {
        ICollection<RequestEntity> All();

        RequestEntity One(int id);
        int Count();

        bool Add(RequestEntity entity);

        bool Delete(int id);
    }
    public class RequestRepository : IRequestRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RequestRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            return _dbContext.Requests.Count();
        }
        public bool Add(RequestEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Requests.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<RequestEntity> All()
        {
            return _dbContext.Requests.Select(n => n).ToList();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.Requests.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public RequestEntity One(int id)
        {
            return _dbContext.Requests.FirstOrDefault(n => n.Id == id) ?? new RequestEntity();
        }

    }
}

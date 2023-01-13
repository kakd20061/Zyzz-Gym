namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IPricingRepository
    {
        ICollection<PricingEntity> All();

        int Count();

        PricingEntity One(int id);

        bool Add(PricingEntity entity);

        bool Delete(int id);

        PricingEntity Edit(PricingEntity entity);
    }

    public class PricingRepository : IPricingRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PricingRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(PricingEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Pricing.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<PricingEntity> All()
        {
            return _dbContext.Pricing.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.Pricing.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            if(entity.PassTypeName != null && entity.PassTypeName != "")
            {
                _dbContext.Pricing.Remove(entity);
            }

            return _dbContext.SaveChanges() > 0;
        }

        public PricingEntity Edit(PricingEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.PassTypeName = entity.PassTypeName;

            dbEntity.Price = entity.Price;

            dbEntity.Description = entity.Description;

            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Pricing.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public PricingEntity One(int id)
        {
            return _dbContext.Pricing.FirstOrDefault(n => n.Id == id) ?? new PricingEntity();
        }

    }

}

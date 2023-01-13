namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IExerciseNameRepository
    {
        ICollection<ExerciseNameEntity> All();

        int Count();

        ExerciseNameEntity One(int id);

        bool Add(ExerciseNameEntity entity);

        bool Delete(int id);

        ExerciseNameEntity Edit(ExerciseNameEntity entity);
    }

    public class ExerciseNameRepository : IExerciseNameRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ExerciseNameRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Add(ExerciseNameEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.ExerciseName.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<ExerciseNameEntity> All()
        {
            return _dbContext.ExerciseName.Select(n => n).ToList();
        }

        public int Count()
        {
            return _dbContext.ExerciseName.Count();
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.ExerciseName.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ExerciseNameEntity Edit(ExerciseNameEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Name = entity.Name;


            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.ExerciseName.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public ExerciseNameEntity One(int id)
        {
            return _dbContext.ExerciseName.FirstOrDefault(n => n.Id == id) ?? new ExerciseNameEntity();
        }

    }

}


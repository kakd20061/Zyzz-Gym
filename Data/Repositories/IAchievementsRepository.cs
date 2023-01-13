using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;

namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IAchievementsRepository
    {
        ICollection<AchievementsEntity> All(string Id);
        ICollection<AchievementsEntity> All2();

        List<AchievementsEntity> Max();

        int Count();

        AchievementsEntity One(int id);

        bool Add(AchievementsEntity entity);

        bool Delete(int id);

        AchievementsEntity Edit(AchievementsEntity entity);
    }

    public class AchievementsRepository : IAchievementsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly SignInManager<NewIdentityUser> _SignInManager;
        private readonly UserManager<NewIdentityUser> _UserManager;
        public AchievementsRepository(ApplicationDbContext dbContext,SignInManager<NewIdentityUser> SignInManager, UserManager<NewIdentityUser> UserManager)
        {
            _dbContext = dbContext;
            _SignInManager = SignInManager;
            _UserManager = UserManager;
        }


        public bool Add(AchievementsEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            _dbContext.Achievements.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<AchievementsEntity> All(string Id)
        {
            return _dbContext.Achievements.Include(n=>n.User).Select(n => n).Where(n=>n.UserForeignKey == Id).ToList();
        }
        public ICollection<AchievementsEntity> All2()
        {
            return _dbContext.Achievements.Include(n => n.User).Select(n => n).ToList();
        }
        public int Count()
        {
            return _dbContext.Achievements.Count();
        }

        public AchievementsEntity Edit(AchievementsEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Weight = entity.Weight;
            dbEntity.Reps = entity.Reps;


            entity.UpdatedAt = DateTime.UtcNow;

            _dbContext.Achievements.Update(dbEntity);

            _dbContext.SaveChanges();

            return dbEntity;
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.Achievements.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public AchievementsEntity One(int id)
        {
            return _dbContext.Achievements.FirstOrDefault(n => n.Id == id) ?? new AchievementsEntity();
        }

        public List<AchievementsEntity> Max()
        {
            var test = new List<AchievementsEntity>();
            var exercises = _dbContext.ExerciseName.Select(n => n).ToList();
            foreach(var exercise in exercises)
            {
                var el = _dbContext.Achievements.Include(n=>n.User).Select(n => n).Where(n => n.ExerciseForeignKey == exercise.Id).ToList();
                if(el.Count>0)
                test.Add(el.MaxBy(n=>n.Weight));
            }
            
            return test;
        }
    }

}


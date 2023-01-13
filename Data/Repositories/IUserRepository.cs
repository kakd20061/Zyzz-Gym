using Microsoft.EntityFrameworkCore;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;

namespace ZyzzGymOriginal.Data.Repositories
{
    public interface IUserRepository
    {
        public ICollection<NewIdentityUser> All();
        int Count();
    }

    public class NewIdentityUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NewIdentityUserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Count()
        {
            return _dbContext.Users.Count();
        }
        public ICollection<NewIdentityUser> All()
        {
            return _dbContext.Users.Include(n=>n.Achievements).Select(n => n).ToList();
        }
    }

}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data.Seeds;

namespace ZyzzGymOriginal.Data
{
    public class ApplicationDbContext : IdentityDbContext<NewIdentityUser>
    {
        public DbSet<AnnouncementEntity> Announcements { get; set; }
        public DbSet<PricingEntity> Pricing { get; set; }
        public DbSet<ExerciseNameEntity> ExerciseName { get; set; }

        public DbSet<AchievementsEntity> Achievements { get; set; }

        public DbSet<NewIdentityUser> Users { get; set; }
        public DbSet<RequestEntity> Requests { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<NewIdentityUser>()
                .HasMany(n => n.Achievements)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserForeignKey);

            builder.Entity<ExerciseNameEntity>()
                .HasMany(n => n.Achievements)
                .WithOne(n => n.ExerciseName)
                .HasForeignKey(n => n.ExerciseForeignKey);

            PricingSeeder.Seed(builder);

            AnnouncementSeeder.Seed(builder);
            ExerciseNameSeeder.Seed(builder);
            //AchievementSeeder.Seed(builder);
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace ZyzzGymOriginal.Data.Seeds
{
    public static class AnnouncementSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<AnnouncementEntity>()
                .HasData(
                    new AnnouncementEntity()
                    {
                        Id = 1,
                        Title = "New whey protein falvours",
                        PhotoUrl = "https://a.allegroimg.com/s1024/0c35f7/641f676d4bf5b3f5b02baa7a23b9",
                        Description = "In cooperation with the kfd company, new whey protein flavors are available in our store!"
                    }
                );
            builder.Entity<AnnouncementEntity>()
                .HasData(
                    new AnnouncementEntity()
                    {
                        Id = 2,
                        Title = "New delivery of WPC",
                        PhotoUrl = "https://static.pepper.pl/threads/raw/RGwF5/582471_1/re/1600x900/qt/60/582471_1.jpg",
                        Description = "In cooperation with the Olimp company, new whey protein complex are available in our store. Check this out!"
                    }
                );
            builder.Entity<AnnouncementEntity>()
                .HasData(
                    new AnnouncementEntity()
                    {
                        Id = 3,
                        Title = "New gym equipment",
                        PhotoUrl = "https://www.ironcompany.com/media/mf_webp/jpg/media/catalog/product/cache/e2c8244c5972c0e74c812d913143823a/l/e/legend-selectedge-1124-multi-press-xlg.webp",
                        Description = "We are happy to say that we have got new modern gym equipment"
                    }
                );
            builder.Entity<AnnouncementEntity>()
                .HasData(
                    new AnnouncementEntity()
                    {
                        Id = 4,
                        Title = "More plates on the gym",
                        PhotoUrl = "https://kronos-shop.pl/pol_pl_HMS-Talerz-Olimpijski-Gumowany-Obciazenie-20-kg-12442_2.jpg",
                        Description = "We bought some more plates to avoid fights for gains!"
                    }
                );
            builder.Entity<AnnouncementEntity>()
                .HasData(
                    new AnnouncementEntity()
                    {
                        Id = 5,
                        Title = "Gym will be closed at 1st December",
                        PhotoUrl = "https://www.klubfitness.njn.pl/photos/40217/235965916_1906319619541469_7780126213647886945_n.jpg.jpg",
                        Description = "Sadly We must announce that gym will be closed at 1st December due to technical break :("
                    }
                );
        }
    }
}

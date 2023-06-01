using CustomerManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MerchantCategory> MerchantCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MerchantCategory>().HasData(
                new MerchantCategory { Id = 1, Name = "eCommerce website", DisplayOrder = 1 },
                new MerchantCategory { Id = 2, Name = "Business website", DisplayOrder = 2 },
                new MerchantCategory { Id = 3, Name = "Blog website", DisplayOrder = 3 }
                );
        }
    }
}

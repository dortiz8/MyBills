using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MyBills.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<CostType> CostTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
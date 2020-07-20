using Microsoft.EntityFrameworkCore;
using MobilesShop.Models;

namespace MobilesShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<PhoneFeatures> Phone { get; set; }
    }
}

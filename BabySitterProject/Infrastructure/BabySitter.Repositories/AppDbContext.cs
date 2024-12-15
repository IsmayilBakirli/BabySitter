using BabySitter.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BabySitter.Repositories
{
    public class AppDbContext:IdentityDbContext<AppUser>
        
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BabySitter.Entities.BabySitter>? BabySitters { get; set; }

        public DbSet<Product>? Products { get; set; }
    }
}

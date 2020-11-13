using Microsoft.EntityFrameworkCore;
using TechDM.Shared;
using TechDM.Shared.Model;

namespace TechDM.Server.Database
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Question> Questions { get; set; }
        
        public DbSet<Technology> Technologies { get; set; }
        
    }
}
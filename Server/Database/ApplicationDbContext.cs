using Microsoft.EntityFrameworkCore;
using TechDM.Shared;

namespace TechDM.Server.Database
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Question> Questions { get; set; }
        
        public DbSet<Technologie> Technologies { get; set; }
        
    }
}
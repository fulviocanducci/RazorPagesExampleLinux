using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class DatabaseContext: DbContext
    {   
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
            Database.EnsureCreated();            
        }
        public DbSet<People> People {get;set;}
    }
}
using Microsoft.EntityFrameworkCore;
using RepoPatternPrac.Models;

namespace RepoPatternPrac.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {    
        }
       public DbSet<Products> prod { get; set; }
       public DbSet<Users> users { get; set; }
    }
}

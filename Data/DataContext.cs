using  Microsoft.EntityFrameworkCore;

namespace dotnet_rpg
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options){

        }

        // public DbSet<Character> Characters { get; set; }
        public DbSet<Character> Characters => Set<Character>();
    }

}
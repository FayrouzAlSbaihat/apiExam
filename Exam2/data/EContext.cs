using Microsoft.EntityFrameworkCore;

namespace Exam2.data
{
    public class EContext:DbContext
    {
        IConfiguration config;

        public EContext(IConfiguration _config)
        {
            config = _config;
        }
       public DbSet <Country> countries { get; set; }
       public DbSet<city> cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString(("Econnection")));
            base.OnConfiguring(optionsBuilder);
        }
    }
}

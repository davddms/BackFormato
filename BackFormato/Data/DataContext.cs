using Microsoft.EntityFrameworkCore;

namespace BackFormato.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Formato> Formatos { get; set; }

        public DbSet<FormatoType> FormatoTypes { get; set; }

        public DbSet<Status> Statuss { get; set; }  


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FormatoType>().HasKey(x => x.FormatoTypeId);
        }
    }
}

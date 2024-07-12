namespace VueApp.Server.Data
{
    using Microsoft.EntityFrameworkCore;
    using VueApp.Server.Models.Entitys;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<DataEntity> Data { get; set; }
        public DbSet<CirclesEntity> Circles { get; set; }
    }
}

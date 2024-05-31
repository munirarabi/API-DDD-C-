using Entityes.Entityes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configurations
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<News> News { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetStringConnection());
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNewUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

        public string GetStringConnection() 
        {
            string strcon = "";
            return strcon;
        }
    }
}

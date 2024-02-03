using CoreProjectApi.DAL.ApiContext.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreProjectApi.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=CoreProjectApiDB;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category2> Categories2 { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

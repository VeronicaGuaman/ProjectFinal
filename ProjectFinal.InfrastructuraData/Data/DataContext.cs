using Microsoft.EntityFrameworkCore;
using ProjectFinal.Domain.Entities;

namespace ProjectFinal.InfrastructuraData.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
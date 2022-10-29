using Microsoft.EntityFrameworkCore;
using HRManagement.Entities;

namespace HRManagement.Data
{
    public class HRAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("HRManagement");
        }
        
    }
}

using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Employees> Employees { get; set; }
    }
}

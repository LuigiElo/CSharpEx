using Microsoft.EntityFrameworkCore;

namespace DNPExamPt2.Data
{
    public class EmployeesContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeesContext(DbContextOptions<EmployeesContext> ctxOptions) : base(ctxOptions) {
        
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source = database.db");
    }
}
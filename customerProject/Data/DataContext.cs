global using Microsoft.EntityFrameworkCore;

namespace customerProject.Data
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01; Database=customerProject; Trusted_Connection=true; TrustServerCertificate=true;");

        }

        public DbSet<Customer> Customers { get; set;}

    }
}


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SportsStore.Models
    
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath($"{Directory.GetCurrentDirectory()}")
           .AddJsonFile("appsettings.Development.json")
           .Build();

           /* var connectionString = configuration["ConnectionStrings:GuestDbConnectionString"];
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));*/
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace crud1.Models
{
    public class DonationDBContext:DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext>options):base(options) 
        { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=kavi;Integrated Security=True;TrustServerCertificate=true");
        }
        public DbSet<DCandidate> DCandidate { get; set; }
    }
}

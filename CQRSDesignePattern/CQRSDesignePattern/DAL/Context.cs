using Microsoft.EntityFrameworkCore;

namespace CQRSDesignePattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KQ16HG1;initial catalog=CQRSDesignP; integrated security=true; ");
        }
        
        public DbSet<Product> Products { get; set; }
    
    }
}

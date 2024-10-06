using Microsoft.EntityFrameworkCore;

namespace MediatorDesignePattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KQ16HG1;initial catalog=MediatorDP; integrated security=true;");

        }
        public DbSet<Product> Products { get; set; }
    }
}

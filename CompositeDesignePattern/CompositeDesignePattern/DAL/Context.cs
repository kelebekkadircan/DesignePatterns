using Microsoft.EntityFrameworkCore;

namespace CompositeDesignePattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KQ16HG1;initial catalog=CompositeDesignePattern; integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}

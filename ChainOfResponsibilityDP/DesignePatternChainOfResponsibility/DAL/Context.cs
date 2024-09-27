using Microsoft.EntityFrameworkCore;

namespace DesignePatternChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KQ16HG1;initial catalog=ChainOfResponsibility; integrated security=true;"); 
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}

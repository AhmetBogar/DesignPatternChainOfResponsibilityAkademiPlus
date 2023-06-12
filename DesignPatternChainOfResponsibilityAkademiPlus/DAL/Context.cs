using Microsoft.EntityFrameworkCore;

namespace DesignPatternChainOfResponsibilityAkademiPlus.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-39VDBOA;initial catalog=AkademiPlusChainOfRespDb;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}

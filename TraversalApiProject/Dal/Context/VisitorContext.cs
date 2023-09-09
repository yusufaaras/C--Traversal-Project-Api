using Microsoft.EntityFrameworkCore;
using TraversalApiProject.Dal.Entities;

namespace TraversalApiProject.Dal.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S1QPNRR; initial catalog=TraversalDbApiProject; integrated security=true; TrustServerCertificate=True;"); 
        }
        public DbSet<Visitor> visitors { get; set; }
    }
}

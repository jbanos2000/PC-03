using Microsoft.EntityFrameworkCore;
using PC_03.Models;

namespace PC_03.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationDbContext(DbContextOptions x) : base (x)
        {
            
        }
    }
}

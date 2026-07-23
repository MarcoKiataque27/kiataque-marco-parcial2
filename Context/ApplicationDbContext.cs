using BackendApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
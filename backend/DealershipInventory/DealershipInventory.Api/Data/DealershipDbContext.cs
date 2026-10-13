using DealershipInventory.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DealershipInventory.Api.Data
{
    public class DealershipDbContext : DbContext
    {
        public DealershipDbContext(DbContextOptions<DealershipDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
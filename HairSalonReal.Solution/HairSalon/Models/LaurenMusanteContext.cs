
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class LaurenMusanteContext : DbContext
    {
        public virtual DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }

        public LaurenMusanteContext(DbContextOptions options) : base(options) { }
    }
}
using Microsoft.EntityFrameworkCore;

namespace web14.Models {
    public class WbContext : DbContext {
        public WbContext() { }
        public WbContext(DbContextOptions<WbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SCARYEMRE\\SQLEXPRESS;Initial Catalog=WebDB;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<Register> Registers { get; set; }
        public DbSet<UyeTipi> Uyetipi { get; set; }
    }
}
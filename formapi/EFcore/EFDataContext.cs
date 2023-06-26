using Microsoft.EntityFrameworkCore;

namespace formapi.EFcore
{
    public class EFDataContext : DbContext {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options){ }

        public DbSet<MasterDatabases> MasterDatabases { get; set; }
        public DbSet<FormData> FormData { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        private DbContextOptions<ApplicationDbContext> _options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }

    }
}

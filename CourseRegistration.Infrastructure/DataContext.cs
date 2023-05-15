using CourseRegistration.Domain;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistration.Infrastructure {
    public class DataContext : DbContext {

        public DbSet<RegistrationFlow> CourseRegistrations { get; set; }
        public DbSet<RegistrationState> RegistrationStates { get; set; }
        public DbSet<Participant> Participants { get; set; }

        public DataContext(DbContextOptions options) : base(options) {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        // TODO: implement OnConfiguring
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        }*/

        // TODO: implement OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }

    }
}
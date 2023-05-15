using CourseRegistration.Domain;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistration.Infrastructure {
    public class DataContext : DbContext {

        public DbSet<RegistrationFlow> CourseRegistrations { get; set; }
        public DbSet<FlowState> FlowStates { get; set; }
        public DbSet<RegistrationState> RegistrationStates { get; set; }
        public DbSet<FlowParticipant> FlowParticipants { get; set; }
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
            modelBuilder.Entity<FlowState>()
                    .HasKey(fs => new { fs.StateId, fs.FlowId});
            modelBuilder.Entity<FlowState>()
                    .HasOne(p => p.RegistrationState)
                    .WithMany(pc => pc.FlowStates)
                    .HasForeignKey(p => p.StateId);
            modelBuilder.Entity<FlowState>()
                    .HasOne(p => p.RegistrationState)
                    .WithMany(pc => pc.FlowStates)
                    .HasForeignKey(c => c.FlowId);

            modelBuilder.Entity<FlowParticipant>()
                    .HasKey(po => new { po.StateId, po.ParticipantId });
            modelBuilder.Entity<FlowParticipant>()
                    .HasOne(p => p.Participant)
                    .WithMany(pc => pc.FlowParticipants)
                    .HasForeignKey(p => p.ParticipantId);
            modelBuilder.Entity<FlowParticipant>()
                    .HasOne(p => p.RegistrationState)
                    .WithMany(pc => pc.FlowParticipants)
                    .HasForeignKey(c => c.StateId);

        }

    }
}
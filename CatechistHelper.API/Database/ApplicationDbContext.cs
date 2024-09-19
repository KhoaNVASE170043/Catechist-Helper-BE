using CatechistHelper.Domain.Common;
using Microsoft.EntityFrameworkCore;
using CatechistHelper.Domain.Entities;

namespace CatechistHelper.API.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        #region DbSet
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewProcess> InterviewProcesses { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(AppConfig.ConnectionString.DefaultConnection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.Entity<Account>().HasIndex(a => a.Email).IsUnique();

            #region Entity Relation
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Role)
                .WithMany(r => r.Accounts)
                .HasForeignKey(a => a.RoleId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Account)
                .WithMany(a => a.Posts)
                .HasForeignKey(p => p.AccountId);

            modelBuilder.Entity<Account>()
               .HasOne(a => a.Candidate)
               .WithOne(c => c.Account)
               .HasForeignKey<Candidate>(c => c.AccountId);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Candidate)
                .WithMany(c => c.Applications)
                .HasForeignKey(a => a.CandidateId);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Application)
                .WithMany(a => a.Interviews)
                .HasForeignKey(i => i.ApplicationId);

            modelBuilder.Entity<InterviewProcess>()
                .HasOne(i => i.Application)
                .WithMany(a => a.InterviewProcesses)
                .HasForeignKey(i => i.ApplicationId);

            modelBuilder.Entity<Application>()
                .HasMany(a => a.Accounts)
                .WithMany(a => a.Applications)
                .UsingEntity<Recruiter>(
                    l => l.HasOne<Account>(e => e.Account).WithMany(e => e.Recruiters).OnDelete(DeleteBehavior.ClientSetNull),
                    r => r.HasOne<Application>(e => e.Application).WithMany(e => e.Recruiters).OnDelete(DeleteBehavior.ClientSetNull));
            #endregion
        }
    }
}

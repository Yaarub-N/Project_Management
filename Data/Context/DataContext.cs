using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<DateRangeEntity> DateRanges { get; set; }
        public DbSet<StatusEntity> Statuses { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProfileEntity> Profiles { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<InvoiceEntity> Invoices { get; set; }
        public DbSet<InvoiceStatusEntity> InvoiceStatuses { get; set; }
        public DbSet<ExpenseEntity> Expenses { get; set; }
        public DbSet<TimesheetEntity> Timesheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurations for specific entities (if needed)
            modelBuilder.Entity<ProjectEntity>()
                .HasKey(p => p.ProjectNumber);

            modelBuilder.Entity<DateRangeEntity>()
                .HasKey(dr => dr.Id);

            modelBuilder.Entity<StatusEntity>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<CustomerEntity>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ProfileEntity>()
                .HasKey(pf => pf.Id);

            modelBuilder.Entity<AddressEntity>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<LocationEntity>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<EmployeeEntity>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<RoleEntity>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<ServiceEntity>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<TaskEntity>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<InvoiceEntity>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<InvoiceStatusEntity>()
                .HasKey(is => is.Id);

            modelBuilder.Entity<ExpenseEntity>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<TimesheetEntity>()
                .HasKey(t => t.Id);

            // Additional configurations
            modelBuilder.Entity<ProjectEntity>()
                .HasOne(p => p.DateRange)
                .WithMany()

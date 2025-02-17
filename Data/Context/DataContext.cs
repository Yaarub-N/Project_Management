using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Context;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
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

        // Unique constraint for ProjectNumber
        modelBuilder.Entity<ProjectEntity>()
            .HasIndex(p => p.ProjectNumber)
            .IsUnique();

        // Defining primary keys
        modelBuilder.Entity<ProjectEntity>().HasKey(p => p.ProjectNumber);
        modelBuilder.Entity<DateRangeEntity>().HasKey(dr => dr.Id);
        modelBuilder.Entity<StatusEntity>().HasKey(s => s.Id);
        modelBuilder.Entity<CustomerEntity>().HasKey(c => c.Id);
        modelBuilder.Entity<ProfileEntity>().HasKey(pf => pf.Id);
        modelBuilder.Entity<AddressEntity>().HasKey(a => a.Id);
        modelBuilder.Entity<LocationEntity>().HasKey(l => l.Id);
        modelBuilder.Entity<EmployeeEntity>().HasKey(e => e.Id);
        modelBuilder.Entity<RoleEntity>().HasKey(r => r.Id);
        modelBuilder.Entity<ServiceEntity>().HasKey(s => s.Id);
        modelBuilder.Entity<TaskEntity>().HasKey(t => t.Id);
        modelBuilder.Entity<InvoiceEntity>().HasKey(i => i.Id);
        modelBuilder.Entity<InvoiceStatusEntity>().HasKey(invStatus => invStatus.Id);
        modelBuilder.Entity<ExpenseEntity>().HasKey(e => e.Id);
        modelBuilder.Entity<TimesheetEntity>().HasKey(t => t.Id);

        // Defining relationships
        modelBuilder.Entity<ProjectEntity>()
            .HasOne(p => p.DateRange)
            .WithMany()
            .HasForeignKey(p => p.DateRangeEntityId);

        modelBuilder.Entity<ProjectEntity>()
            .HasOne(p => p.Customer)
            .WithMany(c => c.Projects)
            .HasForeignKey(p => p.CustomerId);

        modelBuilder.Entity<ProjectEntity>()
            .HasOne(p => p.Service)
            .WithMany(s => s.Projects)
            .HasForeignKey(p => p.ServiceEntityId);

        modelBuilder.Entity<ProjectEntity>()
            .HasOne(p => p.Status)
            .WithMany(s => s.Projects)
            .HasForeignKey(p => p.StatusEntityId);

        modelBuilder.Entity<CustomerEntity>()
            .HasOne(c => c.Profile)
            .WithMany()
            .HasForeignKey(c => c.ProfileEntityId);

        modelBuilder.Entity<ProfileEntity>()
            .HasOne(pf => pf.Address)
            .WithMany()
            .HasForeignKey(pf => pf.AddressEntityId);

        modelBuilder.Entity<AddressEntity>()
            .HasOne(a => a.Location)
            .WithMany()
            .HasForeignKey(a => a.LocationEntityId);

        modelBuilder.Entity<EmployeeEntity>()
            .HasOne(e => e.Role)
            .WithMany(r => r.Employees)
            .HasForeignKey(e => e.RoleEntityId);

        modelBuilder.Entity<InvoiceEntity>()
            .HasOne(i => i.InvoiceStatus)
            .WithMany(invoiceStatus => invoiceStatus.Invoices)
            .HasForeignKey(i => i.InvoiceStatusEntityId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ExpenseEntity>()
            .HasOne(e => e.Project)
            .WithMany(p => p.Expenses)
            .HasForeignKey(e => e.ProjectEntityId);

        modelBuilder.Entity<TimesheetEntity>()
            .HasOne(t => t.Employee)
            .WithMany(e => e.Timesheets)
            .HasForeignKey(t => t.EmployeeEntityId);

        modelBuilder.Entity<TimesheetEntity>()
            .HasOne(t => t.Project)
            .WithMany(p => p.Timesheets)
            .HasForeignKey(t => t.ProjectEntityId);
     

    }

}

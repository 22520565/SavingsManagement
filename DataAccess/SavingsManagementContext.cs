using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public sealed partial class SavingsManagementContext : DbContext
{
    public SavingsManagementContext()
    {
    }

    public SavingsManagementContext(DbContextOptions<SavingsManagementContext> options)
        : base(options)
    {
    }

    public DbSet<CashFlow> CashFlows { get; set; }

    public DbSet<Configuration> Configurations { get; set; }

    public DbSet<CustomerAccount> CustomerAccounts { get; set; }

    public DbSet<Saving> Savings { get; set; }

    public DbSet<SavingInterestRate> SavingInterestRates { get; set; }

    public DbSet<StaffAccount> StaffAccounts { get; set; }

    public DbSet<StaffPermission> StaffPermissions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=QUARK\\QUARK;Initial Catalog=SavingsManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CashFlow>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("UpdateCustomerBalance"));

            entity.Property(e => e.Time).HasDefaultValueSql("(sysdatetimeoffset())");

            entity.HasOne(d => d.Customer).WithMany(p => p.CashFlows)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashFlows_CustomerAccounts");
        });

        modelBuilder.Entity<CustomerAccount>(entity =>
        {
            entity.Property(e => e.IsMale).HasDefaultValue(true);
        });

        modelBuilder.Entity<Saving>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("CloseSavingInsertCashFlow");
                    tb.HasTrigger("OpenSavingInsertCashFlow");
                });

            entity.Property(e => e.OpeningDateTime).HasDefaultValueSql("(sysdatetimeoffset())");

            entity.HasOne(d => d.Customer).WithMany(p => p.Savings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Savings_CustomerAccounts");
        });

        modelBuilder.Entity<SavingInterestRate>(entity =>
        {
            entity.HasKey(e => e.PeriodInMonths).HasName("PK_AnnualInterestRates");
        });

        modelBuilder.Entity<StaffAccount>(entity =>
        {
            entity.HasOne(d => d.Permission).WithMany(p => p.StaffAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaffAccounts_StaffPermissions");
        });

        modelBuilder.Entity<StaffPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Permissions");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

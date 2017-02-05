using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Verify.Models
{
    public partial class VerifyContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        public VerifyContext(DbContextOptions<VerifyContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("PK_People");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasColumnType("char(9)");

                entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.MiddleName).HasMaxLength(16);
            });
        }
    }
}
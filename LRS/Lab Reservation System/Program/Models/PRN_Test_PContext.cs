using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Program.Models
{
    public partial class PRN_Test_PContext : DbContext
    {
        public PRN_Test_PContext()
        {
        }

        public PRN_Test_PContext(DbContextOptions<PRN_Test_PContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookablePeriod> BookablePeriods { get; set; } = null!;
        public virtual DbSet<Lab> Labs { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<TimeSlot> TimeSlots { get; set; } = null!;
        public virtual DbSet<WeekDay> WeekDays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var ConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookablePeriod>(entity =>
            {
                entity.HasKey(e => new { e.LabId, e.WeekDay, e.SlotId })
                    .HasName("PK__Bookable__CE4175582683FBC2");

                entity.ToTable("Bookable_periods");

                entity.Property(e => e.LabId).HasColumnName("lab_id");

                entity.Property(e => e.WeekDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("week_day");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.NoAvailableComputers).HasColumnName("no_available_computers");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.BookablePeriods)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bookable___lab_i__3F466844");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.BookablePeriods)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bookable___slot___412EB0B6");

                entity.HasOne(d => d.WeekDayNavigation)
                    .WithMany(p => p.BookablePeriods)
                    .HasForeignKey(d => d.WeekDay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bookable___week___403A8C7D");
            });

            modelBuilder.Entity<Lab>(entity =>
            {
                entity.Property(e => e.LabId)
                    .ValueGeneratedNever()
                    .HasColumnName("lab_id");

                entity.Property(e => e.LabAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lab_address");

                entity.Property(e => e.NoComputers).HasColumnName("no_computers");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => new { e.LabId, e.WeekDay, e.SlotId, e.StdId })
                    .HasName("PK__Reservat__95F1C57C1627F2BA");

                entity.Property(e => e.LabId).HasColumnName("lab_id");

                entity.Property(e => e.WeekDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("week_day");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.LabId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__lab_i__440B1D61");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__slot___45F365D3");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.StdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__std_i__46E78A0C");

                entity.HasOne(d => d.WeekDayNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.WeekDay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__week___44FF419A");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__Students__0B0245BAF7C27DD2");

                entity.Property(e => e.StdId)
                    .ValueGeneratedNever()
                    .HasColumnName("std_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.HasKey(e => e.SlotId)
                    .HasName("PK__Time_slo__971A01BB48F29045");

                entity.ToTable("Time_slots");

                entity.Property(e => e.SlotId)
                    .ValueGeneratedNever()
                    .HasColumnName("slot_id");

                entity.Property(e => e.FromTime).HasColumnName("from_time");

                entity.Property(e => e.ToTime).HasColumnName("to_time");
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.WeekDay1)
                    .HasName("PK__Week_day__2080B820B0BD8C4B");

                entity.ToTable("Week_days");

                entity.Property(e => e.WeekDay1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("week_day");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

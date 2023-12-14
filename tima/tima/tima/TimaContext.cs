using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace tima;

public partial class TimaContext : DbContext
{
    public TimaContext()
    {
    }

    public TimaContext(DbContextOptions<TimaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<ProblemType> ProblemTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Technician> Technicians { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TIMOXA;Database=tima;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EquipmentType>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EqimentType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DateOrderClose).HasColumnType("date");
            entity.Property(e => e.DateOrderOpen).HasColumnType("date");
            entity.Property(e => e.IdClient).HasColumnName("ID_Client");
            entity.Property(e => e.IdManager).HasColumnName("ID_Manager");
            entity.Property(e => e.IdStatus).HasColumnName("ID_Status");
            entity.Property(e => e.IdTechnician).HasColumnName("ID_Technician");
            entity.Property(e => e.IdTypeEquipment).HasColumnName("ID_TypeEquipment");
            entity.Property(e => e.IdTypeProblem).HasColumnName("ID_TypeProblem");
            entity.Property(e => e.Photo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Statuses");

            entity.HasOne(d => d.IdTechnicianNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdTechnician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Technicians");

            entity.HasOne(d => d.IdTypeEquipmentNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdTypeEquipment)
                .HasConstraintName("FK_Orders_EquipmentTypes");

            entity.HasOne(d => d.IdTypeProblemNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdTypeProblem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_ProblemTypes");
        });

        modelBuilder.Entity<ProblemType>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProblemType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProblemType");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Technician>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdTypeEquipment1).HasColumnName("ID_TypeEquipment_1");
            entity.Property(e => e.IdTypeEquipment2).HasColumnName("ID_TypeEquipment_2");
            entity.Property(e => e.IdTypeEquipment3).HasColumnName("ID_TypeEquipment_3");
            entity.Property(e => e.IdUser).HasColumnName("ID_user");
            entity.Property(e => e.OtherSkills)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfileLink)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTypeEquipment1Navigation).WithMany(p => p.TechnicianIdTypeEquipment1Navigations)
                .HasForeignKey(d => d.IdTypeEquipment1)
                .HasConstraintName("FK_Technicians_EquipmentTypes");

            entity.HasOne(d => d.IdTypeEquipment2Navigation).WithMany(p => p.TechnicianIdTypeEquipment2Navigations)
                .HasForeignKey(d => d.IdTypeEquipment2)
                .HasConstraintName("FK_Technicians_EquipmentTypes1");

            entity.HasOne(d => d.IdTypeEquipment3Navigation).WithMany(p => p.TechnicianIdTypeEquipment3Navigations)
                .HasForeignKey(d => d.IdTypeEquipment3)
                .HasConstraintName("FK_Technicians_EquipmentTypes2");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Technicians)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Technicians_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdRole).HasColumnName("ID_role");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nikname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

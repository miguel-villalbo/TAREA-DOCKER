using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Tarea_9_Docker.Data;

namespace Tarea_9_Docker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231024030046_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.UseIdentityColumns(); 

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleados");

                entity.Property(e => e.idEmpleado)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.PuestoidPuesto)
                    .HasColumnType("int");

                entity.Property(e => e.Telefono)
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.idPuesto)
                    .HasColumnType("int");

                entity.HasKey(e => e.idEmpleado);

                entity.HasIndex(e => e.PuestoidPuesto);

                entity.HasOne(e => e.Puesto)
                    .WithMany()
                    .HasForeignKey(e => e.PuestoidPuesto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.ToTable("Puestos");

                entity.Property(e => e.idPuesto)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                entity.Property(e => e.nombrePuesto)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.HasKey(e => e.idPuesto);
            });
        }
    }
}

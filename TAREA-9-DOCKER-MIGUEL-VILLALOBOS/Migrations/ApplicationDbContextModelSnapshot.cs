using Microsoft.EntityFrameworkCore;
using Tarea_9_Docker.Data;

namespace Tarea_9_Docker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            ConfigureEmpleado(modelBuilder);
            ConfigurePuesto(modelBuilder);
        }

        private void ConfigureEmpleado(ModelBuilder modelBuilder)
        {
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
        }

        private void ConfigurePuesto(ModelBuilder modelBuilder)
        {
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

using System;
using LibraryDomain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LibraryDomain.Infraestructure.Data
{
    public partial class PetsToTheRescueContext : DbContext
    {
        public PetsToTheRescueContext()
        {
        }

        public PetsToTheRescueContext(DbContextOptions<PetsToTheRescueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Especie> Especie { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<RegistroAdopcion> RegistroAdopcion { get; set; }
        public virtual DbSet<RegistroMascotaEncontrada> RegistroMascotaEncontrada { get; set; }
        public virtual DbSet<RegistroMascotaEncontradas> RegistroMascotaEncontradas { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-K8MQT0RA;Database=PetsToTheRescue;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Especie>(entity =>
            {
                entity.HasKey(e => e.IdEspecie);

                entity.Property(e => e.IdEspecie)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Especie");

                entity.Property(e => e.Descripcion).HasMaxLength(75);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Estado");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.HasKey(e => e.IdMascota);

                entity.Property(e => e.IdMascota)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Mascota");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Edad).HasMaxLength(50);

                entity.Property(e => e.FechaDeRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdEspecie).HasColumnName("Id_Especie");

                entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");

                entity.Property(e => e.IdUbigeo).HasColumnName("Id_Ubigeo");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Usuario");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Tamaño).HasMaxLength(50);

                entity.HasOne(d => d.IdEspecieNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdEspecie)
                    .HasConstraintName("FK_Mascota_Especie");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Mascota_Estado");

                entity.HasOne(d => d.IdUbigeoNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdUbigeo)
                    .HasConstraintName("FK_Mascota_Ubigeo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Mascota_Usuario");
            });

            modelBuilder.Entity<RegistroAdopcion>(entity =>
            {
                entity.HasKey(e => e.IdRegistroAdop);

                entity.Property(e => e.IdRegistroAdop)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_RegistroAdop");

                entity.Property(e => e.FechaDeAdopcion).HasColumnType("datetime");

                entity.Property(e => e.IdDueñoAntiguo)
                    .HasMaxLength(50)
                    .HasColumnName("Id_DueñoAntiguo");

                entity.Property(e => e.IdDueñoNuevo)
                    .HasMaxLength(50)
                    .HasColumnName("Id_DueñoNuevo");

                entity.Property(e => e.IdMascota).HasColumnName("Id_Mascota");

                entity.HasOne(d => d.IdDueñoAntiguoNavigation)
                    .WithMany(p => p.RegistroAdopcionIdDueñoAntiguoNavigation)
                    .HasForeignKey(d => d.IdDueñoAntiguo)
                    .HasConstraintName("FK_RegistroAdopcion_Usuario");

                entity.HasOne(d => d.IdDueñoNuevoNavigation)
                    .WithMany(p => p.RegistroAdopcionIdDueñoNuevoNavigation)
                    .HasForeignKey(d => d.IdDueñoNuevo)
                    .HasConstraintName("FK_RegistroAdopcion_Usuario1");

                entity.HasOne(d => d.IdMascotaNavigation)
                    .WithMany(p => p.RegistroAdopcion)
                    .HasForeignKey(d => d.IdMascota)
                    .HasConstraintName("FK_RegistroAdopcion_Mascota");
            });

            modelBuilder.Entity<RegistroMascotaEncontrada>(entity =>
            {
                entity.HasKey(e => e.IdRegistroMe);

                entity.Property(e => e.IdRegistroMe)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_RegistroME");

                entity.Property(e => e.FechaEncuentro).HasColumnType("datetime");

                entity.Property(e => e.IdDni)
                    .HasMaxLength(50)
                    .HasColumnName("Id_DNI");

                entity.Property(e => e.IdMascota).HasColumnName("Id_Mascota");

                entity.Property(e => e.LugarEncuentro).IsRequired();

                entity.HasOne(d => d.IdDniNavigation)
                    .WithMany(p => p.RegistroMascotaEncontrada)
                    .HasForeignKey(d => d.IdDni)
                    .HasConstraintName("FK_RegistroMascotaEncontrada_Usuario");

                entity.HasOne(d => d.IdMascotaNavigation)
                    .WithMany(p => p.RegistroMascotaEncontrada)
                    .HasForeignKey(d => d.IdMascota)
                    .HasConstraintName("FK_RegistroMascotaEncontrada_Mascota");
            });

            modelBuilder.Entity<RegistroMascotaEncontradas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaDeEncuentro).HasColumnType("datetime");

                entity.Property(e => e.IdMascota).HasColumnName("Id_Mascota");

                entity.Property(e => e.IdRegistroMe).HasColumnName("Id_RegistroME");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Usuario");

                entity.HasOne(d => d.IdMascotaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMascota)
                    .HasConstraintName("FK_RegistroMascotaEncontradas_Mascota");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_RegistroMascotaEncontradas_Usuario");
            });

            modelBuilder.Entity<Ubigeo>(entity =>
            {
                entity.HasKey(e => e.IdUbigeo);

                entity.Property(e => e.IdUbigeo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Ubigeo");

                entity.Property(e => e.Departamento).HasMaxLength(75);

                entity.Property(e => e.Distrito).HasMaxLength(75);

                entity.Property(e => e.Region).HasMaxLength(75);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdDni);

                entity.Property(e => e.IdDni)
                    .HasMaxLength(50)
                    .HasColumnName("Id_DNI");

                entity.Property(e => e.Apellidos).HasMaxLength(75);

                entity.Property(e => e.Contraseña).HasMaxLength(100);

                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.FechaDeNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdUbigeo).HasColumnName("Id_Ubigeo");

                entity.Property(e => e.Nombres).HasMaxLength(75);

                entity.Property(e => e.Telefono).HasMaxLength(75);

                entity.HasOne(d => d.IdUbigeoNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdUbigeo)
                    .HasConstraintName("FK_Usuario_Ubigeo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

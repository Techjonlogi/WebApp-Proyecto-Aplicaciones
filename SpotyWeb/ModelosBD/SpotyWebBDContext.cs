using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class SpotyWebBDContext : DbContext
    {
        public SpotyWebBDContext()
        {
        }

        public SpotyWebBDContext(DbContextOptions<SpotyWebBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AlbumCancion> AlbumCancions { get; set; }
        public virtual DbSet<Artistum> Artista { get; set; }
        public virtual DbSet<Cancion> Cancions { get; set; }
        public virtual DbSet<PlayList> PlayLists { get; set; }
        public virtual DbSet<PlayListUsuario> PlayListUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioCancion> UsuarioCancions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=SpotyWebBD;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.IdAlbum);

                entity.ToTable("Album");

                entity.Property(e => e.IdAlbum).HasMaxLength(50);

                entity.Property(e => e.Artista).HasMaxLength(50);

                entity.Property(e => e.Año).HasMaxLength(50);

                entity.Property(e => e.Canciones).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<AlbumCancion>(entity =>
            {
                entity.HasKey(e => e.Album);

                entity.ToTable("Album-Cancion");

                entity.Property(e => e.Album).HasMaxLength(50);

                entity.Property(e => e.Cancion).HasMaxLength(50);

                entity.HasOne(d => d.AlbumNavigation)
                    .WithOne(p => p.AlbumCancion)
                    .HasForeignKey<AlbumCancion>(d => d.Album)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Album-Cancion_Album");

                entity.HasOne(d => d.CancionNavigation)
                    .WithMany(p => p.AlbumCancions)
                    .HasForeignKey(d => d.Cancion)
                    .HasConstraintName("FK_Album-Cancion_Cancion");
            });

            modelBuilder.Entity<Artistum>(entity =>
            {
                entity.HasKey(e => e.IdArtista);

                entity.Property(e => e.IdArtista)
                    .ValueGeneratedNever()
                    .HasColumnName("idArtista");

                entity.Property(e => e.AñoInicio).HasMaxLength(50);

                entity.Property(e => e.NombreArtista).HasMaxLength(50);

                entity.Property(e => e.NumeroAlbumes).HasMaxLength(50);
            });

            modelBuilder.Entity<Cancion>(entity =>
            {
                entity.HasKey(e => e.IdCancion);

                entity.ToTable("Cancion");

                entity.Property(e => e.IdCancion)
                    .HasMaxLength(50)
                    .HasColumnName("idCancion");

                entity.Property(e => e.Album).HasMaxLength(50);

                entity.Property(e => e.Duracion).HasMaxLength(10);

                entity.Property(e => e.Genero).HasMaxLength(50);

                entity.Property(e => e.RutaRecurso).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(50);

                entity.HasOne(d => d.ArtistaNavigation)
                    .WithMany(p => p.Cancions)
                    .HasForeignKey(d => d.Artista)
                    .HasConstraintName("FK_Cancion_Artista");
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.HasKey(e => e.IdPlaylist);

                entity.ToTable("PlayList");

                entity.Property(e => e.IdPlaylist)
                    .HasMaxLength(50)
                    .HasColumnName("idPlaylist");

                entity.Property(e => e.Cancion).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.HasOne(d => d.CancionNavigation)
                    .WithMany(p => p.PlayLists)
                    .HasForeignKey(d => d.Cancion)
                    .HasConstraintName("FK_PlayList_Cancion");
            });

            modelBuilder.Entity<PlayListUsuario>(entity =>
            {
                entity.HasKey(e => e.PlayList);

                entity.ToTable("PlayList-Usuario");

                entity.Property(e => e.PlayList).HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PlayListNavigation)
                    .WithOne(p => p.PlayListUsuario)
                    .HasForeignKey<PlayListUsuario>(d => d.PlayList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayList-Usuario_PlayList");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.PlayListUsuarios)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlayList-Usuario_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.NickName);

                entity.ToTable("Usuario");

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Contraseña).HasMaxLength(50);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Follows)
                    .HasMaxLength(50)
                    .HasColumnName("follows");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<UsuarioCancion>(entity =>
            {
                entity.HasKey(e => e.Usuario);

                entity.ToTable("Usuario-Cancion");

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.Property(e => e.Cancion).HasMaxLength(50);

                entity.HasOne(d => d.CancionNavigation)
                    .WithMany(p => p.UsuarioCancions)
                    .HasForeignKey(d => d.Cancion)
                    .HasConstraintName("FK_Usuario-Cancion_Cancion");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithOne(p => p.UsuarioCancion)
                    .HasForeignKey<UsuarioCancion>(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario-Cancion_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

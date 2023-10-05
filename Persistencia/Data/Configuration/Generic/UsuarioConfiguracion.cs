using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuracion;
    public class UsuarioConfiguracion : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(p => p.Id)
                .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Usuario")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Username)
                .HasColumnName("Username")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.TwoFactorSecret)            
            .HasColumnName("twoFactorSecret")
            .HasMaxLength(50);
        
            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnName("createDate");
                
            builder.HasIndex(u => new{
                u.Username,u.Email
            })
            .HasDatabaseName("IX_Username_Email")
            .IsUnique();




            builder.HasData(
                new {
                    Id = 1,
                    Username = "Andres Gutierrez",
                    Email = "GutierrezAndres514@gmail.com",
                    Password = "1234",
                    CreatedDate = new DateTime (2024,09,24)
                },
                
                new {
                    Id = 2,
                    Username = "Vicky Montañez",
                    Email = "vickyMolina2005@gmail.com",
                    Password = "1234",
                    CreatedDate = new DateTime (2024,09,24)
                },
                new {
                    Id = 3,
                    Username = "Konny Alucema",
                    Email = "lisethtorres969@gmail.com",
                    Password = "12345",
                    CreatedDate = new DateTime (2024,09,24)
                }
            );
        
        }
    }
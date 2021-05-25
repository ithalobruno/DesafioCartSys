using DesafioCartSys.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioCartSys.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Documento)
               .IsRequired()
               .HasColumnType("varchar(11)");

            builder.Property(p => p.Estado_Civil)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(p => p.Ativo)
                   .HasColumnType("int");


            builder.ToTable("Clientes");
        }
    }

}

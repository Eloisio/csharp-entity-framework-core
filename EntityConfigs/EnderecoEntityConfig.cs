using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;

public class EnderecoEntityConfig : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("enderecos");

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("int");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Estado)
            .HasColumnName("estado")
            .HasColumnType("nvarchar(2)")
            .IsRequired();

        builder.Property(x => x.Cidade)
            .HasColumnName("cidade")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(x => x.Bairro)
            .HasColumnName("bairro")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(x => x.Logradouro)
            .HasColumnName("logradouro")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.Property(x => x.Numero)
            .HasColumnName("numero")
            .HasColumnType("nvarchar(10)")
            .IsRequired();

        builder.HasOne<Cliente>()
            .WithOne(cliente => cliente.Endereco)
            .HasForeignKey<Endereco>(endereco => endereco.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
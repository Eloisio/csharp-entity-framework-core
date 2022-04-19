using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;

public class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("produtos");

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .HasColumnName("nome")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.Valor)
            .HasColumnName("valor")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.HasMany(x => x.Pedidos)
            .WithMany(x => x.Produtos);
    }
}
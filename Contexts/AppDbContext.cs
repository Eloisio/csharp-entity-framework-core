using EFCoreExample.EntityConfigs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Endereco> Enderecos => Set<Endereco>();
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<Produto> Produtos => Set<Produto>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=Localhost;Database=CursoEFCore;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration<Cliente>(new ClienteEntityConfig());
        builder.ApplyConfiguration<Endereco>(new EnderecoEntityConfig());
        builder.ApplyConfiguration<Pedido>(new PedidoEntityConfig());
        builder.ApplyConfiguration<Produto>(new ProdutoEntityConfig());
    }
}
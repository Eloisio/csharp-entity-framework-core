using EFCoreExample.Contexts;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();

var cliente = db.Clientes
    .Include(x => x.Endereco)
    .Include(x => x.Pedidos)
    .ThenInclude(x => x.Produtos)
    .First();

Console.WriteLine(cliente);
Console.WriteLine(cliente.Endereco);
Console.WriteLine(cliente.Pedidos.Count);
Console.WriteLine(cliente.Pedidos.Where(x => x.Id == 1).FirstOrDefault().Produtos.Count);
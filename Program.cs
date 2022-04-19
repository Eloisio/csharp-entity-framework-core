using EFCoreExample.Contexts;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();

var cliente = db.Clientes.First();
Console.WriteLine(cliente);
Console.WriteLine(cliente.Endereco);
Console.WriteLine(cliente.Pedidos.Count);

db.Entry(cliente).Reference(x => x.Endereco).Load();
Console.WriteLine(cliente.Endereco);
Console.WriteLine(cliente.Pedidos.Count);


db.Entry(cliente).Collection(x => x.Pedidos).Load();
Console.WriteLine(cliente.Pedidos.Count);

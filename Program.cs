using EFCoreExample.Contexts;

var db = new AppDbContext();

var cliente = db.Clientes.First();
Console.WriteLine(cliente);
Console.WriteLine(cliente.Endereco);
Console.WriteLine(cliente.Pedidos.Count);
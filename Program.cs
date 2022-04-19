using EFCoreExample.Contexts;
using EFCoreExample.Models;

var db = new AppDbContext();

// Criando entidates a partir da propriendade de naveção do lado 1:N
var cliente = db.Clientes.First();
cliente.Pedidos.Add(new Pedido
{
    Descricao = "Meu primeiro pedido",
    Data = DateTime.Now
});
cliente.Pedidos.Add(new Pedido
{
    Descricao = "Meu segundo pedido",
    Data = DateTime.Now
});
db.SaveChanges();

// Criando a entidade a partir da propriedade de navegação do lado N:1
var pedido = new Pedido
{
    Descricao = "Meu segundo pedido",
    Data = DateTime.Now,
    Cliente = cliente
};
db.Add(pedido);
db.SaveChanges();

// Criando a entidade fazendo referencia direta ao id
var pedido2 = new Pedido
{
    Descricao = "Meu terceiro pedido",
    Data = DateTime.Now,
    ClienteId = 2
};
db.Add(pedido);
db.SaveChanges();
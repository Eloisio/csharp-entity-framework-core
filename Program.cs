using EFCoreExample.Contexts;
using EFCoreExample.Models;

var db = new AppDbContext();

var produto = db.Produtos.First();
var produto2 = db.Produtos.Find(3);
var pedido = db.Pedidos.First();

pedido.Produtos.Add(produto);
pedido.Produtos.Add(produto2);
db.SaveChanges();
using EFCoreExample.Contexts;
using EFCoreExample.Models;

var db = new AppDbContext();

// Removendo registro rastreado
var cliente = db.Clientes.First();
db.Remove(cliente);
db.SaveChanges();

// Removendo por ID
var cliente2 = new Cliente { Id = 2 };
db.Remove(cliente2);
db.SaveChanges();
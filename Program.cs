using EFCoreExample.Contexts;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();

// Utilizando registro monitorados
var cliente = db.Clientes.First();
cliente.Nome = "Novo Nome";
db.SaveChanges();

// Uitlizando Update
var cliente2 = new Cliente
{
    Id = 2,
    Nome = "Novo Nome",
    Cpf = "Novo CPF"
};
db.Update(cliente2);
db.SaveChanges();

// Utilizando Entry
var cliente3 = new Cliente
{
    Id = 3,
    Nome = "Novo Nome",
    Cpf = "Novo CPF"
};
db.Entry(cliente3).State = EntityState.Modified;
db.SaveChanges();

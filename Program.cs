using EFCoreExample.Contexts;
using EFCoreExample.Models;

var db = new AppDbContext();

var cliente1 = new Cliente
{
    Nome = "Elton Fonseca",
    Cpf = "123.456.789-12"
};
var cliente2 = new Cliente
{
    Nome = "Wesley Gado",
    Cpf = "456.789.123-34"
};

db.AddRange(cliente1, cliente2);
db.SaveChanges();
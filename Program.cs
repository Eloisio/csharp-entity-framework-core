using EFCoreExample.Contexts;
using EFCoreExample.Models;

var db = new AppDbContext();

// salvando fazendo referencia ao relacionamento
var endereco = new Endereco
{
    Estado = "SP",
    Cidade = "São Paulo",
    Bairro = "Jardim Japão",
    Logradouro = "Rua Dona Piedade Duarte de Oliveira",
    Numero = "263",
    ClienteId = 2
};
db.Add(endereco);
db.SaveChanges();

// salvando fazendo uso da propriendade de navegação
var cliente = new Cliente
{
    Nome = "Cleyson Lima",
    Cpf = "123.456.789-12",
    Endereco = new Endereco
    {
        Estado = "SP",
        Cidade = "São Paulo",
        Bairro = "Cerqueira César",
        Logradouro = "Travessa Alcides Cyrillo",
        Numero = "338"
    }
};
db.Add(cliente);
db.SaveChanges();
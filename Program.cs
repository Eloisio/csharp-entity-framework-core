using EFCoreExample.Contexts;

var db = new AppDbContext();

// Todos os registros
db.Clientes.ToList();

// Busca por id
db.Clientes.Find(1);

// Busca com LINQ
db.Clientes
    .Where(x => x.Nome.Contains("Cleyson"))
    .SingleOrDefault();
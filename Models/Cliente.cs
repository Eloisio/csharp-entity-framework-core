namespace EFCoreExample.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Id}. {Nome} - {Cpf}";
    }
}
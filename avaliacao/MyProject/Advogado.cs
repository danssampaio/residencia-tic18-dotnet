namespace Namespace;
public class Advogado
{
    public string? Name { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? CPF { get; set; }
    public string? CNA { get; set; }
    public Advogado(string? name, DateTime dataNascimento, string? cPF, string? cNA)
    {
        Name = name;
        DataNascimento = dataNascimento;
        CPF = cPF;
        CNA = cNA;
    }
}

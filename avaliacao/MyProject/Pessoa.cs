namespace Namespace;
public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    private string CPF;
    public string cpf
    {
        get { return CPF; }
        set
        {
            if (CpfValido(value))
                CPF = value;
            else
                throw new CpfIsNotValidException();
        }
    }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
    }

    private bool CpfValido(string cpf)
    {
        return !string.IsNullOrEmpty(cpf) && cpf.Length == 11 && cpf.All(char.IsDigit);
    }
}

namespace Namespace;
public class Escritorio
{
    private List<Advogado> advogados;
    private List<Cliente> clientes;

    public Escritorio()
    {
        advogados = new List<Advogado>();
        clientes = new List<Cliente>();
    }

    public void AdicionarAdvogado(Advogado advogado)
    {
        if (!advogados.Exists(a => a.CPF == advogado.CPF) && !advogados.Exists(a => a.CNA == advogado.CNA))
        {
            advogados.Add(advogado);
            Console.WriteLine("Advogado adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("CPF ou CNA já cadastrado para outro advogado.");
        }
    }
}
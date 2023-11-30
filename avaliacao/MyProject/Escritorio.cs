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
        try
        {
            if (!advogados.Exists(a => a.CPF == advogado.CPF) && !advogados.Exists(a => a.CNA == advogado.CNA))
            {
                advogados.Add(advogado);
                Console.WriteLine("Advogado adicionado com sucesso!");
            }
            else
            {
                throw new RepeatedRegisterAttorneyException();
            }
        }
        catch (RepeatedRegisterAttorneyException ex)
        {
            Console.WriteLine($"Erro ao adicionar advogado: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }

    public void AdicionarCliente(Cliente cliente)
    {
        try
        {
            if (!clientes.Exists(c => c.CPF == cliente.CPF))
            {
                clientes.Add(cliente);
                Console.WriteLine("Cliente adicionado com sucesso!");
            }
            else
            {
                throw new RepeatedRegisterClientException();
            }
        }
        catch (RepeatedRegisterClientException ex)
        {
            Console.WriteLine($"Erro ao adicionar cliente: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }

}
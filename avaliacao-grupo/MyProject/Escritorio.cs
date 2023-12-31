namespace EscritorioJuridico;
public class Escritorio
{
    private List<Advogado> advogados;
    public List<Advogado> Advogados => advogados;
    private List<Cliente> clientes;
    public List<Cliente> Clientes => clientes;
    private List<CasoJuridico> casosJuridicos;
    public List<CasoJuridico> CasosJuridicos => casosJuridicos;

    public Escritorio()
    {
        advogados = new List<Advogado>();
        clientes = new List<Cliente>();
        casosJuridicos = new List<CasoJuridico>();
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

    public void ListarAdvogados()
    {
        Console.WriteLine("Lista de Advogados:");
        foreach (var advogado in advogados)
        {
            Console.WriteLine($"Nome: {advogado.Nome}, Data de Nascimento: {advogado.DataNascimento}, CPF: {advogado.CPF}, CNA: {advogado.CNA}");
        }
        Console.WriteLine();
    }

    public void ListarClientes()
    {
        Console.WriteLine("Lista de Clientes:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Data de Nascimento: {cliente.DataNascimento}, CPF: {cliente.CPF}, Estado Civíl: {cliente.EstadoCivil}, Profissão: {cliente.Profissao}");
        }
    }

    public void DeletarAdvogado(string cpf)
    {
        try
        {
            var cpfAdvogado = advogados.Find(a => a.CPF == cpf);

            if (cpfAdvogado != null)
            {
                advogados.Remove(cpfAdvogado);
                Console.WriteLine("Advogado deletado com sucesso!");
            }
            else
            {
                throw new CpfNotFoundException();
            }
        }
        catch (CpfNotFoundException ex)
        {
            Console.WriteLine($"Erro ao deletar advogado: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado ao deletar advogado: {ex.Message}");
        }
    }

    public void DeletarCliente(string cpf)
    {
        try
        {
            var cpfCliente = clientes.Find(c => c.CPF == cpf);

            if (cpfCliente != null)
            {
                clientes.Remove(cpfCliente);
                Console.WriteLine("Cliente deletado com sucesso!\n");
            }
            else
            {
                throw new CpfNotFoundException();
            }
        }
        catch (CpfNotFoundException ex)
        {
            Console.WriteLine($"Erro ao deletar cliente: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado ao deletar cliente: {ex.Message}");
        }
    }
    public void AdicionarCasoJuridico(CasoJuridico casoJuridico)
    {
        casosJuridicos.Add(casoJuridico);
        Console.WriteLine("Caso Jurídico adicionado com sucesso!");
    }


    public void ListarCasosJuridicos()
    {
        Console.WriteLine("Lista de Casos Jurídicos:");
        foreach (var casoJuridico in casosJuridicos)
        {
            ExibirInformacoesCasoJuridico(casoJuridico);
            Console.WriteLine();
        }
    }

    public void DeletarCasoJuridico(string codigo)
    {
        var casoJuridico = casosJuridicos.Find(c => c.Codigo == codigo);

        if (casoJuridico != null)
        {
            casosJuridicos.Remove(casoJuridico);
            Console.WriteLine("Caso Jurídico deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Caso Jurídico não encontrado.");
        }
    }


    public void AtualizarCasoJuridico(string codigo, string novoStatus)
    {
        CasoJuridico? casoParaAtualizar = casosJuridicos.Find(c => c.Codigo == codigo);

        if (casoParaAtualizar != null)
        {
            casoParaAtualizar.Status = novoStatus;
            Console.WriteLine("Caso Jurídico atualizado com sucesso!\n");
        }
        else
        {
            Console.WriteLine($"Caso Jurídico com código {codigo} não encontrado.\n");
        }
    }

    private void ExibirInformacoesCasoJuridico(CasoJuridico casoJuridico)
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"Código: {casoJuridico.Codigo:dd/MM/yyyy}");
        Console.WriteLine($"Abertura: {casoJuridico.Abertura:dd/MM/yyyy}");
        Console.WriteLine($"Probabilidade de Sucesso: {casoJuridico.ProbabilidadeSucesso}%");
        Console.WriteLine($"Encerramento: {casoJuridico.Encerramento:dd/MM/yyyy}");
        Console.WriteLine($"Status: {casoJuridico.Status ?? "N/A"}");

        if (casoJuridico.Cliente != null)
        {
            Console.WriteLine("Informações do Cliente:");
            Console.WriteLine($"Nome: {casoJuridico.Cliente.Nome}");
            Console.WriteLine($"CPF: {casoJuridico.Cliente.CPF}");
        }

        if (casoJuridico.Advogados != null && casoJuridico.Advogados.Count > 0)
        {
            Console.WriteLine("Advogados Envolvidos:");
            foreach (var advogado in casoJuridico.Advogados)
            {
                Console.WriteLine($"Nome: {advogado.Nome}, CPF: {advogado.CPF}");
            }
        }

        if (casoJuridico.Documentos != null && casoJuridico.Documentos.Count > 0)
        {
            Console.WriteLine("Documentos Associados:");
            foreach (var documento in casoJuridico.Documentos)
            {
                casoJuridico.ExibirInformacoesDocumento(documento);
                Console.WriteLine();
            }
        }

        if (casoJuridico.Custos != null && casoJuridico.Custos.Count > 0)
        {
            float somaCustos = 0;
            Console.WriteLine("Custos Associados:");

            foreach (var custo in casoJuridico.Custos)
            {
                Console.WriteLine($"Valor: {custo.Custos}, Descrição: {custo.Descricao}");
                somaCustos += custo.Custos;
            }

            Console.WriteLine($"Total de Custos: {somaCustos}");
        }
        Console.WriteLine("------------------------------------------------------");
    }

    public void AdicionarPagamentoDinheiro(PagamentoEmDinheiro pagamentoEmDinheiro, string cpf)
    {
        try
        {
            var cliente = clientes.Find(c => c.CPF == cpf);

            if (cliente != null)
            {
                cliente.pagamentos.Add(pagamentoEmDinheiro);
                Console.WriteLine("Pagamento adicionado com sucesso!");
            }
            else
            {
                throw new CpfNotFoundException();
            }
        }
        catch (CpfNotFoundException ex)
        {
            Console.WriteLine($"Erro ao adicionar pagamento: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado ao adicionar pagamento: {ex.Message}");
        }
        
        
    }

    public void AdicionarPagamentoCartao(CartaoCredito cartaoDeCredito, string cpf)
    {
        try
        {
            var cliente = clientes.Find(c => c.CPF == cpf);

            if (cliente != null)
            {
                cliente.pagamentos.Add(cartaoDeCredito);
                Console.WriteLine("Pagamento adicionado com sucesso!");
            }
            else
            {
                throw new CpfNotFoundException();
            }
        }
        catch (CpfNotFoundException ex)
        {
            Console.WriteLine($"Erro ao adicionar pagamento: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado ao adicionar pagamento: {ex.Message}");
        }
        
        
    }

     public void AdicionarPagamentoPix(PixBancario pix, string cpf)
    {
        try
        {
            var cliente = clientes.Find(c => c.CPF == cpf);

            if (cliente != null)
            {
                cliente.pagamentos.Add(pix);
                Console.WriteLine("Pagamento adicionado com sucesso!");
            }
            else
            {
                throw new CpfNotFoundException();
            }
        }
        catch (CpfNotFoundException ex)
        {
            Console.WriteLine($"Erro ao adicionar pagamento: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado ao adicionar pagamento: {ex.Message}");
        }
        
        
    }
    
    public void ListarPagamentos(string cpf){

        
        var cliente = clientes.Find(c => c.CPF == cpf);

        if (cliente != null)
        {
            foreach (var pagamento in cliente.pagamentos)
            {
                if(pagamento.desconto == 0){
                  Console.WriteLine($"Descrição: {pagamento.descricao}, Valor Bruto: {pagamento.valorBruto}, Desconto: {pagamento.desconto}, Data: {pagamento.data}");
                }else{
                    Console.WriteLine($"Descrição: {pagamento.descricao}, Valor Bruto: {pagamento.valorBruto}, Desconto: {pagamento.desconto}, Data: {pagamento.data}, Valor Líquido: {pagamento.valorBruto - pagamento.valorBruto* pagamento.desconto/100}");
                }
              
            }
        }
        else
        {
            throw new CpfNotFoundException();
        }
    }

}
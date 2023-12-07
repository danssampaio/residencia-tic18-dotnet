namespace EscritorioJuridico;
class Program
{
    static Escritorio escritorio = new Escritorio();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("---- Menu Principal---- \n" +
            "1. Menu de Cliente\n" +
            "2. Menu de Advogado\n" +
            "3. Menu de Caso Jurídico\n" +
            "4. Menu de Relatório\n" +
            "5. Sair\n");

            Console.Write("Escolha uma opção: ");
            string opcaoMenuPrincipal = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuPrincipal)
            {
                case "1":
                    MenuCliente();
                    break;
                case "2":
                    MenuAdvogado();
                    break;
                case "3":
                    MenuCasoJuridico();
                    break;
                case "4":
                    MenuRelatorio();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // ------- Menus -------

    static void MenuCliente()
    {
        while (true)
        {
            Console.WriteLine("---- Menu de Cliente ---- \n" +
            "1. Adicionar Cliente\n" +
            "2. Listar Clientes\n" +
            "3. Deletar Cliente\n" +
            "4. Voltar ao Menu Principal\n");

            Console.Write("Escolha uma opção: ");
            string opcaoMenuCliente = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuCliente)
            {
                case "1":
                    AdicionarCliente();
                    Console.WriteLine();
                    break;
                case "2":
                    escritorio.ListarClientes();
                    Console.WriteLine();
                    break;
                case "3":
                    DeletarCliente(escritorio);
                    Console.WriteLine();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void MenuAdvogado()
    {
        while (true)
        {
            Console.WriteLine("---- Menu de Advogado ---- \n" +
            "1. Adicionar Advogado\n" +
            "2. Listar Advogados\n" +
            "3. Deletar Advogado\n" +
            "4. Voltar ao Menu Principal\n");

            Console.Write("Escolha uma opção: ");
            string opcaoMenuAdvogado = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuAdvogado)
            {
                case "1":
                    AdicionarAdvogado();
                    Console.WriteLine();
                    break;
                case "2":
                    escritorio.ListarAdvogados();
                    Console.WriteLine();
                    break;
                case "3":
                    DeletarAdvogado(escritorio);
                    Console.WriteLine();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void MenuRelatorio()
    {
        while (true)
        {
            Console.WriteLine("---- Menu de Relatório ---- \n" +
            "1. Relatório: Advogados por Idade\n" +
            "2. Relatório: Clientes por Idade\n" +
            "3. Relatório: Clientes por Estado Civil\n" +
            "4. Relatório: Clientes em Ordem Alfabética\n" +
            "5. Relatório: Clientes por Profissão\n" +
            "6. Relatório: Aniversariantes do Mês\n" +
            "7. Relatório: Casos em Aberto em ordem crescente pela data de inicio\n" +
            "8. Relatório: Advogados em ordem decrescente pela quantidade de casos de  casos com status Concluídos\n" +
            "9. Relatório: Casos com Custo contendo uma palavra na descrição\n" +
            "10. Relatório: Top 10 Tipos de Documentos mais inseridos nos casos\n" +
            "11. Voltar ao Menu Principal\n");


            Console.Write("Escolha uma opção: ");
            string opcaoMenuRelatorio = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuRelatorio)
            {
                case "1":
                    RelatorioAdvogadosPorIdade();
                    Console.WriteLine();
                    break;
                case "2":
                    RelatorioClientesPorIdade();
                    Console.WriteLine();
                    break;
                case "3":
                    RelatorioClientesPorEstadoCivil();
                    Console.WriteLine();
                    break;
                case "4":
                    RelatorioClientesOrdemAlfabetica();
                    Console.WriteLine();
                    break;
                case "5":
                    RelatorioClientesPorProfissao();
                    Console.WriteLine();
                    break;
                case "6":
                    RelatorioAniversariantesDoMes();
                    Console.WriteLine();
                    break;
                case "7":
                        ConsultaCasosEmAberto();
                        Console.WriteLine();
                        break;
                    case "8":
                        ConsultaAdvogadosPorQuantidadeCasosConcluidos();
                        Console.WriteLine();
                        break;
                    case "9":
                        Console.Write("Informe a palavra desejada para consulta: ");
                        string palavraConsulta = Console.ReadLine() ?? "";
                        ConsultaCasosComCustoPorPalavra(palavraConsulta);
                        Console.WriteLine();
                        break;
                    case "10":
                        ConsultaTop10TiposDocumentos();
                        Console.WriteLine();
                        break;
                    case "11":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
               
            }
        }
    }

    static void MenuCasoJuridico()
    {
        while (true)
        {
            Console.WriteLine("---- Menu de Casos Jurídicos ---- \n" +
            "1. Adicionar Caso Jurídico\n" +
            "2. Listar Casos Jurídicos\n" +
            "3. Atualizar Caso Jurídico\n" +
            "4. Deletar Caso Jurídico\n" +
            "5. Voltar ao Menu Principal\n");

            Console.Write("Escolha uma opção: ");
            string opcaoMenuCasoJuridico = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuCasoJuridico)
            {
                case "1":
                    AdicionarCasoJuridico();
                    Console.WriteLine();
                    break;
                case "2":
                    escritorio.ListarCasosJuridicos();
                    Console.WriteLine();
                    break;
                case "3":
                    AtualizarCasoJuridico();
                    Console.WriteLine();
                    break;
                case "4":
                    DeletarCasoJuridico();
                    Console.WriteLine();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void MenuDocumento()
    {
        while (true)
        {
            Console.WriteLine("---- Menu de Documentos ---- \n" +
            "1. Adicionar Documento\n" +
            "2. Listar Documentos\n" +
            "3. Deletar Documento\n" +
            "4. Voltar ao Menu Principal\n");

            Console.Write("Escolha uma opção: ");
            string opcaoMenuDocumento = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcaoMenuDocumento)
            {
                case "1":
                    AdicionarDocumento();
                    Console.WriteLine();
                    break;
                case "2":
                    ListarDocumentos();
                    Console.WriteLine();
                    break;
                case "3":
                    DeletarDocumento();
                    Console.WriteLine();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    
    // ----- Funções Advogado -------
    
    static void AdicionarAdvogado()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Data de Nascimento (DD/MM/AAAA): ");
        DateTime dataNascimento;
        try
        {
            dataNascimento = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy", null);
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de data inválido. Certifique-se de usar o formato DD/MM/AAAA.");
            return;
        }

        Console.Write("CPF: ");
        string cpf = Console.ReadLine() ?? "";
        if (!ValidarCPF(cpf))
        {
            Console.WriteLine("CPF inválido. Certifique-se de inserir um CPF válido.");
            return;
        }

        Console.Write("CNA: ");
        string cna = Console.ReadLine() ?? "";

        Advogado advogado = new Advogado(nome, dataNascimento, cpf, cna);
        escritorio.AdicionarAdvogado(advogado);
        Console.WriteLine();
    }

    static void DeletarAdvogado(Escritorio escritorio)

    {
        Console.Write("Digite o CPF do advogado a ser deletado: ");
        string cpfAdvogado = Console.ReadLine() ?? "";
        escritorio.DeletarAdvogado(cpfAdvogado);
        Console.WriteLine();
    }

    // ------- Funções Cliente -------
    
    static void AdicionarCliente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Data de Nascimento (DD/MM/AAAA): ");
        DateTime dataNascimento;
        try
        {
            dataNascimento = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy", null);
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de data inválido. Certifique-se de usar o formato DD/MM/AAAA.");
            return;
        }

        Console.Write("CPF: ");
        string cpf = Console.ReadLine() ?? "";
        if (!ValidarCPF(cpf))
        {
            Console.WriteLine("CPF inválido. Certifique-se de inserir um CPF válido.");
            Console.WriteLine();
            return;
        }

        Console.Write("Estado Civil (solteiro ou casado): ");
        string estadoCivil = Console.ReadLine() ?? "";

        if (!ValidarEstadoCivil(estadoCivil))
        {
            Console.WriteLine("Estado civíl inválido. Certifique-se de inserir um estado civíl válido.");
            Console.WriteLine();
            return;
        }

        Console.Write("Profissão: ");
        string profissao = Console.ReadLine() ?? "";

        Cliente cliente = new Cliente(nome, dataNascimento, cpf, estadoCivil, profissao);
        escritorio.AdicionarCliente(cliente);
        Console.WriteLine();
    }

    static void DeletarCliente(Escritorio escritorio)
    {
        Console.Write("Digite o CPF do cliente a ser deletado: ");
        string cpfCliente = Console.ReadLine() ?? "";
        escritorio.DeletarCliente(cpfCliente);
        Console.WriteLine();
    }


    // ------- Funções CasoJuridico --------

    static void AdicionarCasoJuridico()
    {
        // Implementar a lógica para iniciar um caso jurídico de acordo com as regras de negócio
        DateTime abertura = DateTime.Now;

        Console.WriteLine($"Qual a probabilidade de sucesso do caso? (0-100): ");
        float probabilidadeDeSucesso = float.Parse(Console.ReadLine() ?? "0");
        string status = "Aberto";

        Cliente clienteAux = new Cliente("nome", DateTime.Now, "cpf", "estadoCivil", "profissao");
        CasoJuridico casoJuridico = new CasoJuridico(abertura, probabilidadeDeSucesso, clienteAux, status);
    }

    static void AtualizarCasoJuridico()
    {
        // Implementar a lógica para atualizar um caso jurídico de acordo com as regras de negócio
        Console.WriteLine("Digite o cpf do cliente do caso juridico a ser atualizado: ");
        string cpfCliente = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o novo status do caso juridico: ");
        string novoStatus = Console.ReadLine() ?? "";
        foreach (var casojuridico in escritorio.CasosJuridicos)
                    {
                        if (casojuridico.Cliente.CPF == cpfCliente)
                        {
                            casojuridico.Status = novoStatus;
                            Console.WriteLine("Caso Jurídico atualizado com sucesso!");
                        }
                        else
                        {
                            throw new CpfNotFoundException();
                        }
                    }
    }

    static void DeletarCasoJuridico()
    {
        // Implementar a lógica para deletar um caso jurídico de acordo com as regras de negócio
        Console.WriteLine("Digite a CPF do cliente do caso juridico a ser deletado: ");
        string cpfCliente = Console.ReadLine() ?? "";
        foreach (var casojuridico in escritorio.CasosJuridicos)
                    {
                        if (casojuridico.Cliente.CPF == cpfCliente)
                        {
                            escritorio.CasosJuridicos.Remove(casojuridico);
                            Console.WriteLine("Caso Jurídico deletado com sucesso!");
                        }
                        else
                        {
                            throw new CpfNotFoundException();
                        }
                    }
    }

    static void ListarCasosJuridicos()
    {
        // Implementar a lógica para listar os casos juridicos
    }

    // ------- Funções Documento --------//

    static Documento AdicionarDocumento()
    {
        // Implementar a lógica para adicionar um documento de acordo com as regras de negócio
        var DataDeModificacao = DateTime.Now;

        Console.WriteLine($"Codigo: ");
        int codigo = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Tipo: ");
        string tipo = Console.ReadLine() ?? "";

        Console.WriteLine($"Descrição: ");
        string descricao = Console.ReadLine() ?? "";

        Documento documento = new Documento(DataDeModificacao, codigo, tipo, descricao);
        return documento;  
    }

    static void ListarDocumentos()
    {
        // Implementar a lógica para listar os documentos
        foreach (var casojuridico in escritorio.CasosJuridicos)
                    {
                        foreach (var documento in casojuridico.Documentos)
                        {
                            Console.WriteLine($"Código: {documento.Codigo}");
                            Console.WriteLine($"Tipo: {documento.Tipo ?? "N/A"}");
                            Console.WriteLine($"Descrição: {documento.Descricao ?? "N/A"}");
                            Console.WriteLine($"Data de Modificação: {documento.DataDeModificacao:dd/MM/yyyy}");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
    }

    static void DeletarDocumento()
    {
        // Implementar a lógica para deletar um documento de acordo com as regras de negócio
        Console.WriteLine("Digite o código do documento a ser deletado: ");
        int codigoDocumento = int.Parse(Console.ReadLine() ?? "0");
        foreach (var casojuridico in escritorio.CasosJuridicos)
                    {
                        foreach (var documento in casojuridico.Documentos)
                        {
                            if (documento.Codigo == codigoDocumento)
                            {
                                casojuridico.Documentos.Remove(documento);
                                Console.WriteLine("Documento deletado com sucesso!!!\n");
                            }
                            else
                            {
                                throw new DocumentoNaoEncontradoException();
                            }
                        }
                    }
    }
    

    // ------- Validações -------
    
    static bool ValidarCPF(string cpf)
    {
        if (cpf.Length == 11 && cpf.All(char.IsDigit))
            return true;
        else
            return false;
    }

    static bool ValidarEstadoCivil(string estadoCivil)
    {
        if (estadoCivil.ToLower() == "solteiro" || estadoCivil.ToLower() == "casado")
            return true;
        else
            return false;
    }

    
    // ------- Relatórios -------
    
    static void RelatorioAdvogadosPorIdade()
    {
        Console.Write("Informe a idade mínima: ");
        int idadeMinima = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Informe a idade máxima: ");
        int idadeMaxima = int.Parse(Console.ReadLine() ?? "999");

        var advogadosPorIdade = escritorio.Advogados
            .Where(advogado => (DateTime.Now - advogado.DataNascimento).Days / 365 >= idadeMinima
                && (DateTime.Now - advogado.DataNascimento).Days / 365 <= idadeMaxima);

        Console.WriteLine("Advogados com idade entre os valores informados:");
        foreach (var advogado in advogadosPorIdade)
        {
            Console.WriteLine($"Nome: {advogado.Nome}, Idade: {(DateTime.Now - advogado.DataNascimento).Days / 365}");
        }
        Console.WriteLine();
    }

    static void RelatorioClientesPorIdade()
    {
        Console.Write("Informe a idade mínima: ");
        int idadeMinima = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Informe a idade máxima: ");
        int idadeMaxima = int.Parse(Console.ReadLine() ?? "999");

        var clientesPorIdade = escritorio.Clientes
            .Where(cliente => (DateTime.Now - cliente.DataNascimento).Days / 365 >= idadeMinima
                && (DateTime.Now - cliente.DataNascimento).Days / 365 <= idadeMaxima);

        Console.WriteLine("Clientes com idade entre os valores informados:");
        foreach (var cliente in clientesPorIdade)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Idade: {(DateTime.Now - cliente.DataNascimento).Days / 365}");
        }
        Console.WriteLine();
    }

    static void RelatorioClientesPorEstadoCivil()
    {
        Console.Write("Informe o estado civil desejado: ");
        string estadoCivil = Console.ReadLine() ?? "";

        if (!ValidarEstadoCivil(estadoCivil))
        {
            Console.WriteLine("Estado civíl inválido. Certifique-se de inserir um estado civíl válido.");
            Console.WriteLine();
            return;
        }

        var clientesPorEstadoCivil = escritorio.Clientes
            .Where(cliente => cliente.EstadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Clientes com estado civil '{estadoCivil}':");
        foreach (var cliente in clientesPorEstadoCivil)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Estado Civil: {cliente.EstadoCivil}");
        }
        Console.WriteLine();
    }

    static void RelatorioClientesOrdemAlfabetica()
    {
        var clientesOrdenados = escritorio.Clientes.OrderBy(cliente => cliente.Nome);

        Console.WriteLine("Clientes em ordem alfabética:");
        foreach (var cliente in clientesOrdenados)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
        }
        Console.WriteLine();
    }

    static void RelatorioClientesPorProfissao()
    {
        Console.Write("Informe o texto da profissão desejada: ");
        string textoProfissao = Console.ReadLine() ?? "";

        var clientesPorProfissao = escritorio.Clientes
            .Where(cliente => cliente.Profissao.Contains(textoProfissao, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Clientes cuja profissão contém '{textoProfissao}':");
        foreach (var cliente in clientesPorProfissao)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Profissão: {cliente.Profissao}");
        }
        Console.WriteLine();
    }

    static void RelatorioAniversariantesDoMes()
    {
        Console.Write("Informe o mês desejado (número): ");
        int mesAniversario = int.Parse(Console.ReadLine() ?? "0");

        var aniversariantesDoMes = escritorio.Advogados
            .OfType<Pessoa>()
            .Concat(escritorio.Clientes)
            .Where(pessoa => pessoa.DataNascimento.Month == mesAniversario);

        Console.WriteLine($"Aniversariantes do mês {mesAniversario}:");
        foreach (var pessoa in aniversariantesDoMes)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Data de Nascimento: {pessoa.DataNascimento:dd/MM/yyyy}");
        }
        Console.WriteLine();
    }
    static void ConsultaCasosEmAberto()
{
    var casosEmAberto = escritorio.CasosJuridicos
        .Where(caso => caso.Status?.Equals("Em aberto", StringComparison.OrdinalIgnoreCase) == true)
        .OrderBy(caso => caso.Abertura);

    Console.WriteLine("Casos em aberto em ordem crescente pela data de início:");
    foreach (var caso in casosEmAberto)
    {
        Console.WriteLine($"Data de Início: {caso.Abertura:dd/MM/yyyy}, Status: {caso.Status ?? "N/A"}");
    }
    Console.WriteLine();
}

static void ConsultaAdvogadosPorQuantidadeCasosConcluidos()
{
    var advogadosPorQuantidadeCasosConcluidos = escritorio.Advogados
        .OrderByDescending(advogado => escritorio.CasosJuridicos
            .Count(caso => caso.Status?.Equals("Concluído", StringComparison.OrdinalIgnoreCase) == true && caso.Advogados.Any(adv => adv == advogado)));

    Console.WriteLine("Advogados em ordem decrescente pela quantidade de casos concluídos:");
    foreach (var advogado in advogadosPorQuantidadeCasosConcluidos)
    {
        int casosConcluidos = escritorio.CasosJuridicos
            .Count(caso => caso.Status?.Equals("Concluído", StringComparison.OrdinalIgnoreCase) == true && caso.Advogados.Any(adv => adv == advogado));

        Console.WriteLine($"Nome: {advogado.Nome}, Casos Concluídos: {casosConcluidos}");
    }
    Console.WriteLine();
}
static void ConsultaCasosComCustoPorPalavra(string palavra)
{
    var casosComCustoPorPalavra = escritorio.CasosJuridicos
        .Where(caso => caso.Custos?.Any(custo => custo.Descricao?.Contains(palavra, StringComparison.OrdinalIgnoreCase) == true) == true);

    Console.WriteLine($"Casos com custo contendo a palavra '{palavra}':");
    foreach (var caso in casosComCustoPorPalavra)
    {
        Console.WriteLine($"Data de Início: {caso.Abertura:dd/MM/yyyy}, Status: {caso.Status ?? "N/A"}");
    }
    Console.WriteLine();
}


static void ConsultaTop10TiposDocumentos()
{
    var documentosPorTipo = escritorio.CasosJuridicos
        .SelectMany(caso => caso.Documentos)
        .GroupBy(documento => documento.Tipo)
        .OrderByDescending(group => group.Count())
        .Take(10);

    Console.WriteLine("Top 10 tipos de documentos mais inseridos nos casos:");
    foreach (var grupo in documentosPorTipo)
    {
        Console.WriteLine($"Tipo: {grupo.Key ?? "N/A"}, Quantidade: {grupo.Count()}");
    }
    Console.WriteLine();
}





}

public class CpfNotFoundException : Exception
{
    public CpfNotFoundException() : base("CPF não encontrado.") { }
}

public class RepeatedRegisterAttorneyException : Exception
{
    public RepeatedRegisterAttorneyException() : base("CPF ou CNA já cadastrado.") { }
}

public class RepeatedRegisterClientException : Exception
{
    public RepeatedRegisterClientException() : base("CPF já cadastrado.") { }
}

public class DocumentoNaoEncontradoException : Exception
{
    public DocumentoNaoEncontradoException() : base("Documento não encontrado.") { }
}

public class CustoNaoEncontradoException : Exception
{
    public CustoNaoEncontradoException() : base("Custo não encontrado.") { }
}

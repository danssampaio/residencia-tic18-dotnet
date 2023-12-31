﻿namespace Namespace;
class Program
{
    static Escritorio escritorio = new Escritorio();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("---- Menu---- \n" +
            "1. Adicionar Advogado\n" +
            "2. Adicionar Cliente\n" +
            "3. Listar Advogados\n" +
            "4. Listar Clientes\n" +
            "5. Deletar Advogado\n" +
            "6. Deletar Cliente\n" +
            "7. Relatório: Advogados por Idade\n" +
            "8. Relatório: Clientes por Idade\n" +
            "9. Relatório: Clientes por Estado Civil\n" +
            "10. Relatório: Clientes em Ordem Alfabética\n" +
            "11. Relatório: Clientes por Profissão\n" +
            "12. Relatório: Aniversariantes do Mês\n" +
            "13. Sair\n");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarAdvogado();
                    Console.WriteLine();
                    break;
                case "2":
                    AdicionarCliente();
                    Console.WriteLine();
                    break;
                case "3":
                    escritorio.ListarAdvogados();
                    Console.WriteLine();
                    break;
                case "4":
                    escritorio.ListarClientes();
                    Console.WriteLine();
                    break;
                case "5":
                    DeletarAdvogado(escritorio);
                    Console.WriteLine();
                    break;
                case "6":
                    DeletarCliente(escritorio);
                    Console.WriteLine();
                    break;
                case "7":
                    RelatorioAdvogadosPorIdade();
                    Console.WriteLine();
                    break;
                case "8":
                    RelatorioClientesPorIdade();
                    Console.WriteLine();
                    break;
                case "9":
                    RelatorioClientesPorEstadoCivil();
                    Console.WriteLine();
                    break;
                case "10":
                    RelatorioClientesOrdemAlfabetica();
                    Console.WriteLine();
                    break;
                case "11":
                    RelatorioClientesPorProfissao();
                    Console.WriteLine();
                    break;
                case "12":
                    RelatorioAniversariantesDoMes();
                    Console.WriteLine();
                    break;
                case "13":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

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
            return;
        }

        Console.Write("Estado Civil: ");
        string estadoCivil = Console.ReadLine() ?? "";

        Console.Write("Profissão: ");
        string profissao = Console.ReadLine() ?? "";

        Cliente cliente = new Cliente(nome, dataNascimento, cpf, estadoCivil, profissao);
        escritorio.AdicionarCliente(cliente);
        Console.WriteLine();
    }
    static bool ValidarCPF(string cpf)
    {
        if (cpf.Length == 11 && cpf.All(char.IsDigit))
            return true;
        else
            return false;
    }


    static void DeletarAdvogado(Escritorio escritorio)
    {
        Console.Write("Digite o CPF do advogado a ser deletado: ");
        string cpfAdvogado = Console.ReadLine() ?? "";
        escritorio.DeletarAdvogado(cpfAdvogado);
        Console.WriteLine();
    }

    static void DeletarCliente(Escritorio escritorio)
    {
        Console.Write("Digite o CPF do cliente a ser deletado: ");
        string cpfCliente = Console.ReadLine() ?? "";
        escritorio.DeletarCliente(cpfCliente);
        Console.WriteLine();
    }

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

}

public class CpfNotFoundException : Exception
{
    public CpfNotFoundException() : base("CPF não encontrado.") { }
}

public class CpfIsNotValidException : Exception
{
    public CpfIsNotValidException() : base("CPF Inválido.") { }
}

public class CnaNotFoundException : Exception
{
    public CnaNotFoundException() : base("CNA não encontrado.") { }
}

public class RepeatedRegisterAttorneyException : Exception
{
    public RepeatedRegisterAttorneyException() : base("CPF ou CNA já cadastrado.") { }
}

public class RepeatedRegisterClientException : Exception
{
    public RepeatedRegisterClientException() : base("CPF já cadastrado.") { }
}

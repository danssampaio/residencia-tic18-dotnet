namespace EscritorioJuridico;

public class CasoJuridico
{
    public string? Codigo { get; set; }
    public DateTime Abertura { get; set; }
    public float ProbabilidadeSucesso { get; set; }
    public List<Documento> Documentos { get; private set; }
    public List<(float Custos, string Descricao)>? Custos { get; set; }
    public DateTime Encerramento { get; set; }
    public List<Advogado>? Advogados { get; set; }
    public Cliente? Cliente { get; set; }
    public string? Status { get; set; }

    public CasoJuridico(string? codigo, DateTime abertura, float probabilidadeSucesso, List<(DateTime DataDeModificacao, int Codigo, string? Tipo, string? Descricao)> documentos,
                        List<(float Custos, string Descricao)>? custos, DateTime encerramento,
                        List<Advogado>? advogados, Cliente? cliente, string? status)
    {
        Codigo = codigo;
        Abertura = abertura;
        ProbabilidadeSucesso = probabilidadeSucesso;
        Documentos = documentos.Select(doc => new Documento(doc.DataDeModificacao, doc.Codigo, doc.Tipo, doc.Descricao)).ToList();
        Custos = custos;
        Encerramento = encerramento;
        Advogados = advogados;
        Cliente = cliente;
        Status = status;
    }

    public void ExibirInformacoesCaso()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Abertura: {Abertura}");
        Console.WriteLine($"Probabilidade de Sucesso: {ProbabilidadeSucesso:P2}");
        Console.WriteLine("Documentos:");
        foreach (var documento in Documentos)
        {
            ExibirInformacoesDocumento(documento);
        }
        if (Custos != null)
        {
            Console.WriteLine("Custos:");
            foreach (var (custo, descricao) in Custos)
            {
                Console.WriteLine($"  - {descricao}: {custo:C2}");
            }
        }
        Console.WriteLine($"Encerramento: {Encerramento}");
        if (Advogados != null)
        {
            Console.WriteLine("Advogados:");
            foreach (var advogado in Advogados)
            {
                Console.WriteLine($"Nome: {advogado.Nome}, Data de Nascimento: {advogado.DataNascimento}, CPF: {advogado.CPF}, CNA: {advogado.CNA}");
            }
        }
        if (Cliente != null)
        {
            Console.WriteLine($"Nome: {Cliente.Nome}, Data de Nascimento: {Cliente.DataNascimento}, CPF: {Cliente.CPF}, Estado Civíl: {Cliente.EstadoCivil}, Profissão: {Cliente.Profissao}");
        
        }
        Console.WriteLine($"Status: {Status}\n");
    }

    public void ExibirInformacoesDocumento(Documento documento)
    {
        Console.WriteLine($"Código: {documento.Codigo}");
        Console.WriteLine($"Tipo: {documento.Tipo ?? "N/A"}");
        Console.WriteLine($"Descrição: {documento.Descricao ?? "N/A"}");
        Console.WriteLine($"Data de Modificação: {documento.DataDeModificacao:dd/MM/yyyy}");
    }
}

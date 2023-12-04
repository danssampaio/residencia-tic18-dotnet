namespace EscritorioJuridico;

public class CasoJuridico
{
    public DateTime Abertura { get; set; }
    public float ProbabilidadeSucesso { get; set; }
    public List<Documento> Documentos { get; private set; } // Agora é uma lista direta de Documentos
    public List<(float Custos, string Descricao)>? Custos { get; set; }
    public DateTime Encerramento { get; set; }
    public List<Advogado>? Advogados { get; set; }
    public Cliente? Cliente { get; set; }
    public string? Status { get; set; }

    public CasoJuridico(DateTime abertura, float probabilidadeSucesso, List<(DateTime DataDeModificacao, int Codigo, string? Tipo, string? Descricao)> documentos,
                        List<(float Custos, string Descricao)>? custos, DateTime encerramento,
                        List<Advogado>? advogados, Cliente? cliente, string? status)
    {
        Abertura = abertura;
        ProbabilidadeSucesso = probabilidadeSucesso;
        Documentos = documentos.Select(doc => new Documento(doc.DataDeModificacao, doc.Codigo, doc.Tipo, doc.Descricao)).ToList();
        Custos = custos;
        Encerramento = encerramento;
        Advogados = advogados;
        Cliente = cliente;
        Status = status;
    }
    public void AdicionarDocumento(Documento documento)
    {
        Documentos.Add(documento);
        Console.WriteLine("Documento adicionado ao Caso Jurídico com sucesso!");
    }

    public void ListarDocumentos()
    {
        Console.WriteLine("Documentos Associados ao Caso Jurídico:");
        foreach (var documento in Documentos)
        {
            ExibirInformacoesDocumento(documento);
            Console.WriteLine();
        }
    }

    public void DeletarDocumento(int codigo)
    {
        try
        {
            var documento = Documentos.Find(d => d.Codigo == codigo);

            if (documento != null)
            {
                Documentos.Remove(documento);
                Console.WriteLine("Documento deletado com sucesso!!!\n");
            }
            else
            {
                throw new DocumentoNaoEncontradoException();
            }
        }
        catch (DocumentoNaoEncontradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }

    private void ExibirInformacoesDocumento(Documento documento)
    {
        Console.WriteLine($"Código: {documento.Codigo}");
        Console.WriteLine($"Tipo: {documento.Tipo ?? "N/A"}");
        Console.WriteLine($"Descrição: {documento.Descricao ?? "N/A"}");
        Console.WriteLine($"Data de Modificação: {documento.DataDeModificacao:dd/MM/yyyy}");
    }
}

namespace Namespace;
public class Documento
{

    public DateTime DataDeModificacao { get; set; }
    public int Codigo { get; set;}
    public string? Tipo { get; set; }
    public string? Descricao {get; set;}

    public Documento(DateTime dataDeModificacao, int codigo, string? tipo, string? descricao)
    {
        DataDeModificacao = dataDeModificacao;
        Codigo = codigo;
        Tipo = tipo;
        Descricao = descricao;
    }

}

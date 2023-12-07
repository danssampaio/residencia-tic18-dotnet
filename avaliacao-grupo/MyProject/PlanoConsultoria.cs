namespace EscritorioJuridico;
public class PlanoConsultoria{
    public string Titulo { get; set; }
    public double Valor { get; set; }
    public List<string> Beneficios { get; set; }


    public PlanoConsultoria(string titulo, double valor, List<string> beneficios){
        this.Titulo = titulo;
        this.Valor = valor;
        this.Beneficios = beneficios;
    }



}
namespace EscritorioJuridico;
public interface IPagamento
{

   public string? descricao {get; set;}

   public double valorBruto {get; set;}

   public double desconto {get; set;}

   public DateTime data {get; set;}

   

   public void RealizarPagamento(double valor);

   public void DescontoPagamento(double valor);

   
   
}

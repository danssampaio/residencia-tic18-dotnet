namespace EscritorioJuridico;
public interface IPagamento
{

   public string tipo {get; set;}
   public string descricao {get; set;}

   public double valorBruto {get; set;}

   public double Desconto {get; set;}

   public DateTime Data {get; set;}
      



   public void RealizarPagamento(double valor);

   public void DescontoPagamento(double valor);
   
}

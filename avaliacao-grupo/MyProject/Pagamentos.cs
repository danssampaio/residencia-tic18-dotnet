namespace EscritorioJuridico;

public class CartaoCredito : IPagamento{

   public string? NumeroCartao { get; set; }
    public string? tipo { get; set; }
    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double Desconto { get; set; }
    public DateTime Data { get; set; }
   
   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
   public void DescontoPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
}


public class PixBancario: IPagamento{

    public string? tipo { get; set; }
    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double Desconto { get; set; }
    public DateTime Data { get; set; }

   public string chavePix {get; set;}
   public string tipoChave {get; set;}

   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com transferência por pix");
   }

   
   public void DescontoPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
}

public class PagamentoEmDinheiro : IPagamento{

    public string? tipo { get; set; }
    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double Desconto { get; set; }
    public DateTime Data { get; set; }

   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado em dinheiro");
   }

   
   public void DescontoPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
   
}

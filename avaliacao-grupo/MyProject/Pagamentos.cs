namespace EscritorioJuridico;

public class CartaoCredito : IPagamento{
    

    public string? numeroCartao { get; set; }
    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double desconto { get; set; }
    public DateTime data { get; set; }
   
   public CartaoCredito(string numerocartao, string descricao, double valorBruto, double desconto, DateTime data)
    {
         this.numeroCartao = numerocartao;
         this.descricao = descricao;
         this.valorBruto = valorBruto;
         this.desconto = desconto;
         this.data = data;
    }


   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
}


public class PixBancario: IPagamento{

    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double desconto { get; set; }
    public DateTime data { get; set; }
   public string chavePix {get; set;}
   public string tipoChave {get; set;}

    public PixBancario( string descricao, double valorBruto, double desconto, DateTime data, string chave, string tipo)
    {

         this.descricao = descricao;
         this.valorBruto = valorBruto;
         this.desconto = desconto;
         this.data = data;
         this.tipoChave = tipo;
         this.chavePix = chave;
    }


   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com transferência por pix");
   }


}

public class PagamentoEmDinheiro : IPagamento{

    public string? descricao { get; set; }
    public double valorBruto { get; set; }
    public double desconto { get; set; }
    public DateTime data { get; set; }

        public PagamentoEmDinheiro( string descricao, double valorBruto, double desconto, DateTime data)
    {

         this.descricao = descricao;
         this.valorBruto = valorBruto;
         this.desconto = desconto;
         this.data = data;
    }

   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado em dinheiro");
   }


   
}

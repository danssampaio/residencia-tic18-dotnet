public class Vehicle
{
    public string Modelo { get; set; }
    public int Ano { get; }
    public string Cor { get; set; }

    public Vehicle(string modelo, int ano, string cor)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }
    
    public int IdadeVeiculo 
    { 
        get 
        { 
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        } 
    }

    public void showCar(){
        Console.WriteLine($"{Modelo} - {Ano} - {Cor}");   
    }
}

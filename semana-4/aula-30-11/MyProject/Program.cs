class Program{
    static void Main(){
        Vehicle car = new Vehicle("Honda Civic", 2020, "Vermelho");
        car.showCar();
        Console.WriteLine("Idade do veículo: " + car.IdadeVeiculo + " anos");
    }
}
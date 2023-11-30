class Program
{
    static Stock stock = new Stock();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Adicionar Produto\n" +
            "2. Obter Produto\n" +
            "3. Atualizar Estoque\n" +
            "4. Gerar Relatórios\n" +
            "5. Sair\n");

            Console.Write("Selecione a opção: ");
            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "2":
                    GetProduct();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "3":
                    UpdateStock();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "4":
                    stock.GenerateReports();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "5":
                    Environment.Exit(0);
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção Inválida. Tente Novamente.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Nome do Produto: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Código do Produto: ");
        int code = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Quantidade em Estoque: ");
        int quantity = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Valor Unitário (com vírgula): ");
        double price = double.Parse(Console.ReadLine() ?? "");

        stock.AddProduct(code, name, quantity, price);
    }

    static void GetProduct()
    {
        Console.Write("Entre com o código do produto: ");
        int code = int.Parse(Console.ReadLine() ?? "");

        stock.GetProduct(code);
    }

    static void UpdateStock()
    {
        Console.Write("Entre com o código do produto: ");
        int code = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Adicionar: valor positivo\nRemover: valor negativo\n\n");
        Console.Write("Quantidade: ");
        int quantityChange = int.Parse(Console.ReadLine() ?? "");

        stock.UpdateStock(code, quantityChange);
    }
}

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException() : base("Produto não encontrado."){}
}

public class InsufficientQuantityException : Exception
{
    public InsufficientQuantityException() : base("Quantidade insuficiente em estoque para realizar a retirada."){}
}

public class RepeatedCodeException : Exception
{
    public RepeatedCodeException() : base("Já existe um produto com o código inserido no estoque."){}
}

public class InvalidCodeException : Exception
{
    public InvalidCodeException() : base("Código inválido. Deve ser um número inteiro positivo.")
    {
    }
}

public class InvalidNameException : Exception
{
    public InvalidNameException() : base("Nome inválido. Não pode estar vazio ou conter caracteres especiais.")
    {
    }
}

public class InvalidInputException : Exception
{
    public InvalidInputException() : base("Quantidade ou preço inválidos. Devem ser números positivos.")
    {
    }
}
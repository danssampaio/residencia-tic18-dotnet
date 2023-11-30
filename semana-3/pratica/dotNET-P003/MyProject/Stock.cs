public class Stock
{
    private List<Product> products = new List<Product>();

    public void AddProduct(int _code, string _name, int _quantity, double _price)
    {
        try
        {
            if (products.Any(p => p.code == _code))
            {
                throw new RepeatedCodeException();
            }

            Product newProduct = new Product
            {
                code = _code,
                name = _name,
                quantity = _quantity,
                price = _price
            };

            products.Add(newProduct);
            Console.WriteLine("Produto Adicionado!!\n");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro ao adicionar o produto. Insira valores válidos.\n");
        }
        catch (RepeatedCodeException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
    }


    public void GetProduct(int _code)
    {
        try
        {
            var product = products.FirstOrDefault(p => p.code == _code);

            if (product == null)
                throw new ProductNotFoundException();

            Console.WriteLine($"Código: {product.code}, Nome: {product.name}, Quantidade: {product.quantity}, Preço: {product.price}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
        catch (ProductNotFoundException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
    }

    public void UpdateStock(int _code, int quantityChange)
    {
        try
        {
            var product = products.FirstOrDefault(p => p.code == _code);

            if (product == null)
                throw new ProductNotFoundException();

            if (product.quantity + quantityChange < 0)
                throw new InsufficientQuantityException();

            product.quantity += quantityChange;
            Console.WriteLine("Estoque Atualizado!!\n");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
        catch (ProductNotFoundException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
        catch (InsufficientQuantityException ex)
        {
            Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}\n");
        }
    }

    public void GenerateReports()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha o relatório:\n\n" +
            "1. Produtos com quantidade abaixo do limite\n" +
            "2. Produtos entre um intervalo de preços\n" +
            "3. Valor total do estoque\n" +
            "4. Sair\n\n");

            Console.Write("Selecione a opção: ");
            string option = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (option)
            {
                case "1":
                    GenerateReport1();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();

                    break;

                case "2":
                    GenerateReport2();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "3":
                    GenerateReport3();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
                    Console.ReadKey();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void GenerateReport1()
    {
        Console.Write("Limite para o relatório 1: ");
        int limitQuantity = int.Parse(Console.ReadLine() ?? "");

        var report1 = products.Where(p => p.quantity < limitQuantity);
        Console.WriteLine("\nRelatório 1 – Produtos com quantidade abaixo do limite: ");

        foreach (var product in report1)
            Console.WriteLine($"Código: {product.code}, Nome: {product.name}, Quantidade: {product.quantity}");
    }

    private void GenerateReport2()
    {
        Console.Write("\nValor mínimo para o relatório 2: ");
        double minPrice = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Valor máximo para o relatório 2:  ");
        double maxPrice = double.Parse(Console.ReadLine() ?? "");

        var report2 = products.Where(p => p.price >= minPrice && p.price <= maxPrice);
        Console.WriteLine($"\nRelatório 2 - Produtos entre {minPrice} e {maxPrice}: ");

        foreach (var product in report2)
            Console.WriteLine($"Código: {product.code}, Nome: {product.name}, Preço: {product.price}");
    }

    private void GenerateReport3()
    {
        var totalStockValue = products.Sum(p => p.quantity * p.price);
        Console.WriteLine($"\nRelatório 3:\n\nValor total do estoque: {totalStockValue}");

        Console.WriteLine("\nValor total de cada produto de acordo com o estoque:");
        foreach (var product in products)
        {
            var productTotalValue = product.quantity * product.price;
            Console.WriteLine($"{product.name}: Quantidade: {product.quantity}, Total em R$: {productTotalValue}");
        }
    }


}

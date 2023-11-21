#region 0 -> 30

Console.WriteLine("\n --- Divisores --- \n");

for (int i = 0; i <= 30; i++)
{
    if (i % 3 == 0 || i % 4 == 0)
        Console.Write(i + " ");
}

Console.WriteLine();

#endregion

#region fibonacci

Console.WriteLine("\n --- Fibonacci --- \n");

int fib1 = 0, fib2 = 1, fib;
Console.Write(fib1 + " " + fib2 + " ");
fib = fib1 + fib2;
while (fib <= 100)
{
    Console.Write(fib + " ");
    fib1 = fib2;
    fib2 = fib;
    fib = fib1 + fib2;
}

Console.WriteLine();

#endregion


#region Tabela 

Console.WriteLine("\n --- Tabela --- \n");

int value = 8;

for(int i = 1; i <= value; i++){
    for(int j = 1; j <= i; j++){
        Console.Write(i*j + " ");
    }
    Console.WriteLine();
}

#endregion

Console.WriteLine();

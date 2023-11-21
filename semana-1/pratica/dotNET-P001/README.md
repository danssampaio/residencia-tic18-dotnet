### 1. Configuração do Ambiente: 
 
Problema: Como você pode verificar se o .NET SDK está corretamente instalado em 
seu sistema? Em um arquivo de texto ou Markdown, liste os comandos que podem 
ser usados para verificar a(s) versão(ões) do .NET SDK instalada(s), como remover e 
atualizar. 

R: 
- Para verificar a versão do .NET SDK podemos utilizar o comando dotnet --version
- Para listar as instaladas dotnet --list-sdks
- Para atualizar dotnet new --update-check
- Para remover dotnet-core-uninstall remove


### 2. Tipos de Dados: 
 
Problema: Quais são os tipos de dados numéricos inteiros disponíveis no .NET? Dê exemplos de uso para cada um deles através de exemplos. 
 
- sbyte: Inteiro de 8 bits com sinal, de -128 a 127.
- byte: Inteiro de 8 bits sem sinal, de 0 a 255.
- short: Inteiro de 16 bits com sinal, de -32.768 a 32.767.
- ushort: Inteiro de 16 bits sem sinal, de 0 a 65.535.
- int: Inteiro de 32 bits com sinal, de -2.147.483.648 a 2.147.483.647.
- uint: Inteiro de 32 bits sem sinal, de 0 a 4.294.967.295.
- long: Inteiro de 64 bits com sinal, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807.
- ulong: Inteiro de 64 bits sem sinal, de 0 a 18.446.744.073.709.551.615.

Exemplos:

- sbyte idade = 25;
- byte temperatura = 30;
- short populacao = 10000;
- ushort codigo = 12345;
- int distancia = 100000;
- uint habitantes = 5000000;
- long distanciaTotal = 1000000000;
- ulong particulas = 1000000000000;

### 3. Conversão de Tipos de Dados: 
 
Problema: Suponha que você tenha uma variável do tipo double e deseja convertê-la em um tipo int. Como você faria essa conversão e o que aconteceria se a parte fracionária da variável double não pudesse ser convertida em um int? Resolva o problema através de um exemplo em C#. 

- Podemos utilizar o método Convert.ToInt32() arredondando para o inteiro mais próximo. Caso queira utilizar somente a parte inteira, podemos truncar fazendo casting.

#### Método:

    double val = 25.52;
    int res = Convert.ToInt32(val);
    Console.WriteLine("Convertendo double {0} para inteiro {1}", val, res);

#### Casting:

    double number = 25.52;
    int integerNumber = (int)number;
    Console.WriteLine("Double: " + number);
    Console.WriteLine("Integer: " + integerNumber);
  
 
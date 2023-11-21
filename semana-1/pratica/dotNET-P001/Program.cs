using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

#region Questão 4 

int x = 10;
int y = 3;

//Sum
Console.WriteLine("Soma = " + (x + y));

//Sub
Console.WriteLine("Soma = " + (x - y));

//Mult
Console.WriteLine("Soma = " + (x * y));

//Div
Console.WriteLine("Soma = " + (x / y));


#endregion


#region Questão 5 

int a = 5;
int b = 8;

static string cmp(int a, int b)
{
    if (a > b)
        return "a é maior que b";
    else if (a < b)
        return "b é maior que a";
    return "a e b são iguais";
}

Console.WriteLine(cmp(a, b));

#endregion

#region Questão 6 

string str1 = "Hello";
string str2 = "World";

static string cmp2(string str1, string str2)
{
    if (str1.Equals(str2))
        return "As strings são iguais";
    return "As strings não são iguais";
}

Console.WriteLine(cmp2(str1, str2));

#endregion


#region Questão 7

bool condicao1 = true;
bool condicao2 = true;

static string cmp3(bool condicao1, bool condicao2)
{
    if (condicao1.Equals(condicao2))
        return "As condições são iguais";
    return "As condições não são iguais";
}

Console.WriteLine(cmp3(condicao1, condicao2));

#endregion

#region Questão 8

int num1 = 7;
int num2 = 3;
int num3 = 10;

bool condition = num1 > num2 && num3 == num1 + num2;
string result = condition ? "num1 é maior que num2 e num3 é igual a num1 + num2" : "As condições não são atendidas";

Console.WriteLine(result);

#endregion
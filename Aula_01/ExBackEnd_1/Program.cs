// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

Console.WriteLine("-+-+-+-+-+ Entrada/Saida e Operadores +-+-+-+-+-");
/*
//Fundamentais - 1 - Soma de dois números

Console.WriteLine("1-Soma de dois números");
Console.WriteLine("Ingresse Numero 1: ");
int numero11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero12 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero11 + numero12);

//Fundamentais - 2 - Produto de dois números
Console.WriteLine("\n");
Console.WriteLine("2 - Produto de dois números");
Console.WriteLine("Ingresse Numero 1: ");
int numero21 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero22 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero21 * numero22);

//Fundamentais - 3 - Diferença
Console.WriteLine("\n");
Console.WriteLine("3 - Diferença");
Console.WriteLine("Ingresse Numero 1: ");
int numero31 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero32 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero31 - numero32);

//Intermediario - 1 - Média de três números
Console.WriteLine("\n");
Console.WriteLine("Intermediario - 1 - Média de três números");
Console.WriteLine("Ingresse Numero 1: ");
double numero41 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
double numero42 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresse Numero 3: ");
double numero43 = Convert.ToDouble(Console.ReadLine()); 
double numero44 = numero41 + numero42 + numero43;
Console.WriteLine(numero44 / 3);

//Intermediario - 2 - Resto da divisão
Console.WriteLine("\n");
Console.WriteLine("Intermediario - 2 - Resto da divisão");
Console.WriteLine("Ingresse Numero 1: ");
double numero51 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
double numero52 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(numero51 % numero52);

//Avançado - 1 - Troca de valores sem variável auxiliar
Console.WriteLine("\n");
Console.WriteLine("Avançado - 1 - Troca de valores sem variável auxiliar");
Console.WriteLine("Ingresse Numero 1: ");
double numero61 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
double numero62 = Convert.ToDouble(Console.ReadLine());

numero61 = numero61 +  numero62;
numero62 = numero61 - numero62;
numero61 = numero61 - numero62;
Console.WriteLine($"Numero 1: {numero61}");
Console.WriteLine($"Numero 2: {numero62}");

//Avançado - 2 - Par ou Ímpar (utilizando operadores de comparação e aritméticos)
    Console.WriteLine("\n");
    Console.WriteLine("Avançado - 2 - Par ou Ímpar (utilizando operadores de comparação e aritméticos");
    Console.WriteLine("Ingresse Numero 1: ");
    int numero71 = Convert.ToInt32(Console.ReadLine());

    do
    {
        numero71 = numero71 % 2;
    } while (numero71 > 2);

    if (numero71 == 0)
    {
        Console.WriteLine("É numero PAR");
    }
    else
    {
        Console.WriteLine("É numero IMPAR");
    }
    //outro jeito de fazer o IF acima
    Console.WriteLine(numero71 == 0 ? "1" : "0");

//Avançado - 3 - Valor máximo entre três números (usando operadores de comparação
Console.WriteLine("\n");
Console.WriteLine("Avançado - 3 - Valor máximo entre três números (usando operadores de comparação");
Console.WriteLine("Ingresse Numero 1: ");
int numero81 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero82 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 3: ");
int numero83 = Convert.ToInt32(Console.ReadLine());

if (numero81 >= numero82)
{
    Console.WriteLine(numero81 >= numero83 ? $"O numero maior é {numero81}" : $"O numero maior é {numero83}");
    //if (numero81 >= numero83) 
    //{
    //    Console.WriteLine($"O numero maior é {numero81}");
    //} else 
    //{
    //    Console.WriteLine($"O numero maior é {numero83}");
    //}
}else
{
    Console.WriteLine(numero82 >= numero83 ? $"O numero maior é {numero82}" : $"O numero maior é {numero83}");
    //if (numero82 >= numero83)
    //{
    //    Console.WriteLine($"O numero maior é {numero82}");
    //}
    //else
    //{
    //    Console.WriteLine($"O numero maior é {numero83}");
    //}
}


Console.WriteLine("-+-+-+-+-+ Estruturas Condicionais +-+-+-+-+-");

//Fundamentais - 1 - Maior de Dois Números
Console.WriteLine("\n");
Console.WriteLine("Fundamentais - 1 - Maior de Dois Números");
Console.WriteLine("Ingresse Numero 1: ");
int numero91 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero92 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numero91 >= numero92 ? $"O numero maior é {numero91}" : $"O numero maior é {numero92}");

//Fundamentais - 2 - Classificação de Idade
Console.WriteLine("\n");
Console.WriteLine("Fundamentais - 2 - Classificação de Idade");
Console.WriteLine("Ingresse sua idade: ");
int numero101 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numero101 >= 0 && numero101 <= 12 ? "Criança" : numero101 >= 13 && numero101 <= 17 ? "Adolescente" : "Adulto");

//Fundamentais - 3 - Par ou Ímpar
Console.WriteLine("\n");
Console.WriteLine("Fundamentais - 3 - Par ou Ímpar");
Console.WriteLine("Ingresse Numero 1: ");
int numero121 = Convert.ToInt32(Console.ReadLine());

do
{
    numero121 = numero121 % 2;
} while (numero121 > 2);

Console.WriteLine(numero121 == 0 ? "É numero par" : "É numero impar");

//Intermediários - 4 - Maior de Três Números
Console.WriteLine("\n");
Console.WriteLine("Intermediários - 4 - Maior de Três Números");
Console.WriteLine("Ingresse Numero 1: ");
int numero131 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 2: ");
int numero132 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse Numero 3: ");
int numero133 = Convert.ToInt32(Console.ReadLine());

if (numero131 >= numero132)
{
    Console.WriteLine(numero131 >= numero133 ? $"O numero maior é {numero131}" : $"O numero maior é {numero133}");
}
else
{
    Console.WriteLine(numero132 >= numero133 ? $"O numero maior é {numero132}" : $"O numero maior é {numero133}");
}

//Intermediários - 5 - Cálculo do Delta (Fórmula de Bhaskara)
Console.WriteLine("\n");
Console.WriteLine("Intermediários - 5 - Cálculo do Delta (Fórmula de Bhaskara)");
Console.WriteLine("Ingresse coeficientes  1: ");
float numero141 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresse coeficientes  2: ");
float numero142 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresse coeficientes  3: ");
float numero143 = float.Parse(Console.ReadLine());

double delta = (numero142 * numero142) - (4 * numero141 * numero143);
Console.WriteLine($"Delta {delta}");

float x = (float)Math.Sqrt(delta);
x = x / (2 * numero141);

String XText = x.ToString(); 
Console.WriteLine($"x= {XText}");
Console.WriteLine($"x= -{XText}");


//Intermediários - 6 - Calculadora Simples
Console.WriteLine("\n");
Console.WriteLine("Intermediários - 6 - Calculadora Simples");
Console.WriteLine("Ingresse numero  1: ");
float numero151 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresse numero  2: ");
float numero152 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresse a Operaçao: + - * /");
char operacao = Convert.ToChar(Console.ReadLine());

switch (operacao)
{
    case '+':
        Console.WriteLine(numero151 + numero152);
        break;
    case '-':
        Console.WriteLine(numero151 - numero152);
        break;
    case '*':
        Console.WriteLine(numero151 * numero152);
        break;
    case '/':
        Console.WriteLine(numero151 / numero152);
        break;
    default:
        Console.WriteLine("Operaçao incorreta");
        break;
}

//Avançados - 7 - Ano Bissexto
Console.WriteLine("\n");
Console.WriteLine("Avançados - 7 - Ano Bissexto");
Console.WriteLine("Ingresse ano: ");
int ano = Convert.ToInt32(Console.ReadLine());

int resto = ano % 100;

if (resto == 0)
{
    resto = ano % 400;
    Console.WriteLine((resto == 0) ? "É ano bisiesto 1" : "Nao é ano bisiesto 1");
}else
{
    resto = ano % 4;
    Console.WriteLine((resto == 0) ? "É ano bisiesto 2" : "Nao é ano bisiesto 2");
}


//Avançados - 8 - Triângulo Válido e Tipo
Console.WriteLine("\n");
Console.WriteLine("Avançados - 8 - Triângulo Válido e Tipo");
Console.WriteLine("Ingresse lado  1: ");
int lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse lado  2: ");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresse lado 3: ");
int lado3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(lado1 < lado2 + lado3 ? (lado2 < lado1 + lado3 ? (lado3 < lado1 + lado2 ? "É TRIANGULO" : "Não é triangulo L3"): "Não é triangulo: L2"): "Não é triangulo: L1");
bool sim = (lado1 < lado2 + lado3 ? (lado2 < lado1 + lado3 ? (lado3 < lado1 + lado2 ? true : false) : false) : false);

if (sim == true)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("É Triangulo Equilatero");
    }
    else
    {
        if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Console.WriteLine("É Triangulo Isosceles");
        }
        else
        {
            Console.WriteLine("É Triangulo Escaleno");
        }
    }
}
else 
{
    Console.WriteLine("Não é triangulo");
}

*/

//Avançados - 9 - Classificação de Nota
Console.WriteLine("\n");
Console.WriteLine("Avançados - 9 - Classificação de Nota");
Console.WriteLine("Ingresse Nota: ");
int nota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (nota <= 100 && nota >= 90 ? 'A' : (nota < 90 && nota >= 80 ? 'B' : (nota < 80 && nota >= 70 ? 'C' : (nota < 70 && nota >= 60 ? 'D' : 'F'))));
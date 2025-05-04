// ------------------------------- Funções -------------------------------

// --------- Fundamentais ---------
//1- Função de Soma

using System.Collections;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
/*
static int soma()
{
    Console.WriteLine("Ingressa o primeiro numero: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingressa o segundo numero: ");
    int j = Convert.ToInt32(Console.ReadLine());

    return i + j;
}

Console.WriteLine($"O total é {soma()}");
*/

//2- Função de Média
/*
List<double> notas = new List<double>();

Console.WriteLine("Quantas notas são: ");
int qtd = Convert.ToInt32(Console.ReadLine());

double promedio = media(notas, qtd);
Console.WriteLine(promedio);

static double media (List<double> list, int qtd)
{
    double sumaNotas = 0;
    for (int i = 0; i < qtd; i++)
    {
        Console.WriteLine($"Inserir nota {i+1}: ");
        list.Add(Convert.ToDouble(Console.ReadLine()));
        sumaNotas += list[i];
    }

    double promedio = sumaNotas / qtd;
    return promedio;
}
*/

//3-Função de Par ou Ímpar
/*
Console.WriteLine("Escreve um numero");
int numero = Convert.ToInt32(Console.ReadLine());

parImpar(numero);

static void parImpar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("Numero par");
    }
    else
    {
        Console.WriteLine("Numero impar");
    }
}
*/

// --------- Intermediários ---------
//1- Função de Fatorial
/*
Console.WriteLine("Escreve um numero");
int numero = Convert.ToInt32(Console.ReadLine());
int fact = Convert.ToInt32(factorial(numero));

Console.WriteLine($"O factorial desse numero é: {fact}");

static int factorial(int numero)
{
    int fact = 1;
    
    if (numero != 0)
    {
        for (int i = 1; i <= numero; i++)
        {
            fact *= i;
        }
    }
    return fact;
}
*/

//2- Função para Inverter String
/*
Console.WriteLine("Qual é seu nome?");
String nome = Console.ReadLine();

Console.WriteLine(inverter(nome));

static string inverter (string nome)
{
    var nomeChar = nome.ToCharArray();
    string nomeInvertido = "";

    for (int i = nomeChar.Length; i> 0; i--)
    {
        nomeInvertido = nomeInvertido + nomeChar[i-1];
    }

    //tambem conseguimos fazer assim
    //foreach (char letra in nomeInvertido.Reverse()) 
    //{
    //    Console.WriteLine(letra);
    //}

    return nomeInvertido;
}
*/

//3- Função para Contar Vogais
/*
Console.WriteLine("Ingressar palavra ou frasse");
string palavra = Console.ReadLine().ToUpper();

Console.WriteLine(contarVogais(palavra));

static int contarVogais(string palavra)
{
    int contador = 0;

    var palavraChar = palavra.ToCharArray();

    for (int i = palavraChar.Length; i > 0; i--)
    {
        if (palavraChar[i - 1] == 'A') contador++;
        if (palavraChar[i - 1] == 'E') contador++;
        if (palavraChar[i - 1] == 'I') contador++;
        if (palavraChar[i - 1] == 'O') contador++;
        if (palavraChar[i - 1] == 'U') contador++;
    }

    return contador;
}
*/

// --------- Avançados ---------
//1- Função para Verificar Número Primo
/*
Console.WriteLine("Ingressar numero para conhecer se é numero primo");
int numero = Convert.ToInt32(Console.ReadLine());

numeroPrimo(numero);

static void numeroPrimo(double numero)
{
    double aux;
    bool ePrimo = false;

    for (int i = 2;  i < numero; i++)
    {
        aux = numero % i;

        if (aux == 0)
        {
            ePrimo = true;
            break;
        }
    }
    if (ePrimo) {
        Console.WriteLine("Não é numero primo");
    }
    else
    {
        Console.WriteLine("É numero primo");
    }
}
*/

//2- Função de Busca em Array
/*
List<char> lista = new List<char>();
char letra;

do
{
    Console.WriteLine($@"Ingressar caracteres
Para sair, colocar X");
    letra = Convert.ToChar(Console.ReadLine().ToUpper());
    lista.Add(letra);
} while (letra != 'X');


Console.WriteLine("Ingrese um numero");
int numero = Convert.ToInt32(Console.ReadLine());

char numChar = Convert.ToChar(numero + '0'); 

buscarNumero(lista, numChar);


static void buscarNumero(List<char> lista, char numero)
{
    bool existe = false;

    foreach (char c in lista)
    {
        Console.WriteLine(c);
        Console.WriteLine(numero);

        if (c == numero)
        {
            existe = true;
        }
    }

    if (existe)
    {
        Console.WriteLine("O numero existe na lista");
    }
    else
    {
        Console.WriteLine("Não existe o numero na lista de entrada");
    }
}
*/

//3- Função Recursiva para Fibonacci
/*
Console.WriteLine("Ingresse a possicao Fibonacci que quer conhecer");
int pos = int.Parse(Console.ReadLine());

fibonacci(pos);

static void fibonacci(int possicao)
{
    List <int> fibonacci = new List <int>();

    int fib = 0;
    int ant = 0;
    int aux = 0;

    for (int i = 1; i <= possicao; i++)
    {
        if (i <= 2)
        {
            fib = 1;
            ant = fib;
            //Console.WriteLine($"{fib}, ");
        }
        else
        {
            aux = fib;
            fib = fib + ant;
            ant = aux;
            //Console.WriteLine($"{fib}, ");
        }
        fibonacci.Add(fib);

        Console.WriteLine(string.Join(", ", fibonacci));   
    }
    Console.WriteLine($@"=======================
A posicão {possicao} tem como valor {fib}
");
}
*/



// --------- DESAFIOS ---------
// --------- Nível Fácil ---------
/*
//1-Calculadora
Console.WriteLine($@"Escolher a operação
======================
+  -> Soma
-  -> Resta
*  -> Multiplicação
/  -> Divição");

char operacaco = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Inserir 2 numeros para calcular");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());

calculadora(num1, num2, operacaco);


static void calculadora(double num1, double num2, char operacaco)
{
    double resultado = 0;

    switch (operacaco)
    {
        case '+':
            resultado = num1 + num2;
            break;
        case '-':
            resultado = num1 - num2;
            break;
        case '*':
            resultado = num1 * num2;
            break;
        case '/':
            resultado = num1 / num2;
            break;
        default:
            Console.WriteLine("ERRO. Operação somente + - * /");
            break;
    }

    Console.WriteLine($"El resultado da operação é {resultado}");
}
*/
/*
//2-Tabuada
Console.WriteLine("Ingressar um numero para exibir a tabuada 1 ao 10");
int num = Convert.ToInt32(Console.ReadLine());

tabuada (num);


void tabuada(int num)
{
    for (int i = 0; i <=10 ; i++)
    {
        Console.WriteLine($"{i} * {num} = " + (i * num));
    }
}
*/
/*
//3-Verificador de Par ou Ímpar
Console.WriteLine("Ingressa um numero");
int numParImpar = Convert.ToInt32(Console.ReadLine());

funParImpar(numParImpar);


void funParImpar(int numParImpar)
{
    if (numParImpar % 2 == 0)
    {
        Console.WriteLine("É numero par");
    } else
    {
        Console.WriteLine("É numero impar");
    }
}
*/

// --------- Nível Médio ---------
/*
//1- Cálculo de Consumo de Combustível
Console.WriteLine("Qual é a distancia em kilometros é seu viagem");
double distancia = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual é o consumo do carro Km/L");
double consumo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informar o valor do combustivel por litro (L)");
double preco  = Convert.ToDouble(Console.ReadLine());

calcularValorTotal (distancia, consumo, preco);


void calcularValorTotal(double distancia, double consumo,  double preco)
{
    Console.WriteLine("O valor total do viagem é " + (distancia / consumo) * preco);
}
*/
/*
//2- Cálculo de Preço Final
Console.WriteLine("Qual é o preço do produto");
double preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Desconto");
double desconto  = Convert.ToDouble(Console.ReadLine());

aplicarDesconto(preco, desconto);


void aplicarDesconto(double preco, double desconto)
{
    Console.WriteLine("O preço final com desconto é " + (preco - (preco * (desconto / 100))));
}
*/
/*
//3- Controle de Ingressos
Console.WriteLine("Número de Ingresso:");
int ingresso = Convert.ToInt32(Console.ReadLine());

controlDeIngresso(ingresso);


void controlDeIngresso(int ingresso)
{
    if (ingresso < 1000 || ingresso > 9999)
    {
        Console.WriteLine("Ingresso inválido");
    }
    else if (ingresso % 2 == 0)
    {
        Console.WriteLine("Ganhou uma pipoca");
    }
    else
    {
        Console.WriteLine("Disfruta do Show");
    }
    ;
}
*/

// --------- Nível Desafiador ---------
/*
//1- Jogo da Adivinhação
bool acertou = false;
Console.WriteLine($@"Adivinha o numero oculto
Por favor inserir um numero entre 1 ao 10");

do
{
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 0 || numero > 10)
    {
        Console.WriteLine("Solo numeros do 1 ao 10");
    }
    else
    {
        acertou = adivinha(numero);
    }
} while (acertou == false);


static bool adivinha(int numero)

{
    Random numeroAleatorio = new Random();
    
    if (numero == numeroAleatorio.Next(1, 10))
    {
        Console.WriteLine(numero);Console.WriteLine("Acertastes");
        return true;
    }
    else
    {
        Console.WriteLine("Intentalo denovo");
        return false;
    }
}
*/
/*
//2- Média de Notas
Console.WriteLine("Inserir a primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserir a segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserir a terceira nota");
double nota3 = Convert.ToDouble(Console.ReadLine());

mediaDaNota(nota1, nota2, nota3);


void mediaDaNota(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if (media > 0 && media < 4.9)
    {
        Console.WriteLine($"Você foi Reprovado {media}");
    } else if (media > 4.9 && media < 6)
    {
        Console.WriteLine($"Você esta em Recuperação {media}");
    }
    else
    {
        Console.WriteLine($"Parabens, foi esta Aprovado {media}");
    }
}
*/

//3- Validador de Senha com Tentativas
Console.WriteLine("Inserir usuario e senha");

validarAcesso();

void validarAcesso()
{
    const string usuario = "USUARIO";
    const string senha = "SENHA";
    int cont = 3;
    bool accessoOk = false;

    do
    {
        Console.WriteLine("USUARIO: ");
        string usuEnt = Console.ReadLine().ToUpper();
        Console.WriteLine("SENHA: ");
        string senhaEnt = Console.ReadLine().ToUpper();

        if (usuario != usuEnt || senha != senhaEnt)
        {
            cont--;
            Console.WriteLine($"Usuario ou senha incorreto, quedam {cont} intentos");

            if (cont == 0)
            {
                Console.WriteLine("Numero de intentos exedido, Bye");
            }
        }
        else
        {
            Console.WriteLine("Acesso correto");
            accessoOk = true;
        }

    } while (cont != 0 && accessoOk == false);
}
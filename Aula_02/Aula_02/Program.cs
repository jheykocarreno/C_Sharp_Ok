//============================ Exercícios ============================
//
//======= Estruturas de repetição =======
//======= Fundamentais =======
/*
//1- Contagem de 1 a 10
for (int i = 1; i <=10 ; i++)
{
    Console.WriteLine(i);
}
*/
/*
//2- Números Pares até 20
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/
/*
//3- Contagem de Números Positivos
Console.WriteLine("Inserir 5 numeros inteiros, entre negativos e positivos");
int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Os numeros possitivos são: ");

for (int i = 0;i < numeros.Length; i++)
{
    if (numeros[i] > 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
*/

//======= Intermediários =======
/*
//4- Soma de 1 a N
Console.WriteLine("Inserir um numero");
int numero = Convert.ToInt32(Console.ReadLine());
int soma=0;

for (int i = 0; i <= numero; i++)
{
    soma += i;
}

Console.WriteLine($"A soma total de todos os numero até {numero} é {soma}");
*/
/*
//5- Média de Notas
Console.WriteLine("Inserir 5 notas");
int[] numeros = new int[5];
double soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    soma += numeros[i];
}

double media = soma / 5;

Console.WriteLine("A media de suas notas é " +  media);
*/
/*
//6- Contagem Regressiva
Console.WriteLine("Inserir um numero");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = numero; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/
/*
//7- Verificação de Número Primo
Console.WriteLine("Inserir um numero");
double numero = Convert.ToDouble(Console.ReadLine());
bool naoPrimo = false;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        naoPrimo = true;
        break;
    }
}

if (naoPrimo == true)
{
    Console.WriteLine("O numero não é Primo");
} else
{
    Console.WriteLine("O numero é primo");
}
*/

/*
//8- Jogo de Adivinhação(Mais Simples)
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
        Random numeroAleatorio = new Random();

        if (numero == numeroAleatorio.Next(1, 10))
        {
            Console.WriteLine(numero); Console.WriteLine("Acertastes");
            acertou = true;
        }
        else
        {
            Console.WriteLine("Intentalo denovo");
            acertou = false;
        }
    }
} while (acertou == false);
*/

/*
//9- Fatorial de um Número (Com Limite)
Console.WriteLine($"Por favor inserir um numero entre 1 ao 10");

int factorial = 1;
bool numeroOk = false;

do
{
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 0 || numero > 10)
    {
        Console.WriteLine("Solo numeros do 1 ao 10");
        numeroOk = false;
    }
    else
    {
        if (numero != 0)
        {
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
        }
        numeroOk = true;
    }
} while (numeroOk == false);

Console.WriteLine($"O factorial desse numero é: {factorial}");
*/

/*
//10-Números Ímpares em um Intervalo
Console.WriteLine("Vamos mostrar os numeros impares entre dois numeros");
Console.WriteLine("Inserir o primeiro numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserir o segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());

int aux;
if (num1 > num2)
{
    aux = num1;
    num1 = num2;
    num2 = aux;
}

for (int i = num1;  i <= num2; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
*/

//======= Arrays =======
//======= Fundamentais =======
/*
//1- Soma dos Elementos
int[] numeros = new int[5];
int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingressa o numero {i+1}");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    soma += numeros[i];
}

Console.WriteLine($"A soma de todos os numero é {soma}");
*/
/*
//2- Maior e Menor Valor
int[] numeros = new int[10];
int maior = 0;
int menor = 0;
bool primeiraVez = true;

Console.WriteLine("Inserir 10 numeros");

for (int i = 0; i < 10; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    if (primeiraVez){
        maior = numeros[i];
        menor = numeros[i];
        primeiraVez = false;
    }

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine($@"O numero maior da lista é: {maior}
O numero menor da lista é: {menor}");
*/
/*
//3- Média dos Valores
Console.WriteLine("Inserir 6 numeros para calcular su media");
double[] numeros = new double[6];
double soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToDouble(Console.ReadLine());
    soma += numeros[i];
}

Console.WriteLine($"A media dos numeros ingressados é {soma / numeros.Length}");
*/


//======= Intermediários =======
/*
//1- Contagem de Números Pares
int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Inserir o numero {i+1}: ");
    numeros[i] = Convert.ToInt32( Console.ReadLine() );
}

Console.WriteLine("Segue os numeros pares");

for  (int i = 0;i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
*/
/*
//2- Inversão de Elementos
Console.WriteLine("Ingressar 8 numeros");
int[] numeros = new int[8];
int[] inverso = new int[8];
int j = 7;

for (int i = 0; i < 8; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    inverso[j] = numeros[i];
    j--;
}

for (int i = 0; i < 8; i++)
{
    Console.WriteLine(inverso[i]);
}
*/
/*
//3-Frequência de um Número
Console.WriteLine("Por favor inserir 10 numeros");
int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Inserir outro numero para contar as repetições na lista anterior");
int num = Convert.ToInt32(Console.ReadLine());

int contador = 0;

for (int i = 0;i < numeros.Length;i++)
{
    if (numeros[i] == num)
    {
        contador++;
    }
}

Console.WriteLine("O numero se repete " + contador);
*/

//======= Avançados =======

//1- Remover Duplicados
Console.WriteLine("Inserir 10 numeros");
int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Inserir o {i+1}º numero");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int[] semDuplicados = numeros.Distinct().ToArray();
Console.WriteLine("Sem duplicados: " + string.Join(", ", semDuplicados));
Console.WriteLine(string.Join(", ", numeros));
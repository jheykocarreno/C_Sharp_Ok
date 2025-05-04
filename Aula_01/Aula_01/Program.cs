// See https://aka.ms/new-console-template for more information

string nome = "Jheyko";
int idade = 41;
char genero = 'M';
float altura = 1.70f;
const double pi = 3.14;
bool estudante = true;

//Console.WriteLine("Hello, World!");
//Console.WriteLine($"Nome: {nome}\nIdade: {idade}");

//Console.WriteLine("Qual é seu novo nome?");
//nome = Console.ReadLine();

//Console.WriteLine($"O seu novo Nome é: {nome}\nEstudante {estudante}");

//estudante = false;
//Console.WriteLine($"O seu novo Nome é: {nome}\nEstudante {estudante}");

//Console.WriteLine("Idade atual e: ");
//idade = Convert.ToInt32( Console.ReadLine() );
//Console.WriteLine($"Nome: {nome}\nIdade: {idade}");

Console.WriteLine("\nNova altura:");
altura = float.Parse( Console.ReadLine() );
Console.WriteLine($"Altura: {altura}");

Console.WriteLine("\nNovo genero:");
genero = Convert.ToChar( Console.ReadLine());
Console.WriteLine($"Generooooo novo: { genero}");

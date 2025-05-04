//POO( Programação Orientada a Objetos)
//Fundamentais


using Aula04_Exercicios.Classes;

//Pessoa pessoa = new Pessoa();
Pessoa pessoa = new Pessoa("Pedro", 3);


//pessoa.nome = "Pedro";
//pessoa.idade = 3;


pessoa.ExibirDados();

Console.WriteLine("\nInserir a nova idade");
Console.Write("> ");
int novaIdade = int.Parse(Console.ReadLine());

pessoa.AlterarIdade(novaIdade);

pessoa.ExibirDados();

Funcionario funcionario = new Funcionario();
funcionario.nome = "Funcionario";
funcionario.idade = 20;
funcionario.salario = 100;
funcionario.ExibirDados();

funcionario.Apresentar();
funcionario.Apresentar("Cionario");
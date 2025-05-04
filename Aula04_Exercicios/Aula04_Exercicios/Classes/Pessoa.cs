using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios.Classes
{

    //Fundamentais - 1 - Criando uma Classe
    class Pessoa
    {
        public string nome;
        public int idade;

        //Intermediario - 1 - Construtores
        public Pessoa() { }
        public Pessoa(string name, int years)
        {
            this.nome = name;
            this.idade = years;
        }

        //Fundamentais - 2- Métodos Simples
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome} e idade: {idade}");
        }

        //Fundamentais - 3- Encapsulamento - Propriedades
        public void AlterarIdade(int novaIdade)
        {
            if (novaIdade >  0)
            {
                idade = novaIdade;
            }
            else
            {
                Console.WriteLine("A nova idade deve ser maior a 0");
            }
        }

        //Avanzado - 3 - Polimorfismo - Sobrecarga
        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {nome}");
        }

        public void Apresentar(string sobrenome)
        {
            Console.WriteLine($"ola, meu nome é {nome} {sobrenome}");
        }
    }

}




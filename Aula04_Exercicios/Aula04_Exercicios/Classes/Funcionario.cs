using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios.Classes
{
    class Funcionario : Pessoa
    {
        public double salario;

        public Funcionario() { }

        public Funcionario(string nome, int idade, double salario) : base (nome, idade)
        {
            this.salario = salario;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salario: {salario:F2}");
        }
    }
}

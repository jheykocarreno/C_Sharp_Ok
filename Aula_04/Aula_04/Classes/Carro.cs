using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04.Classes
{
    public class Carro
    {
        public string Marca;
        public string Cor;
        public string Placa;
        public int Ano;
        public string Dono;

        public void ExibirInfo()
        {
            Console.WriteLine($@"
Marca: {Marca}
Cor: {Cor}
Placa: {Placa}
Ano: {Ano}
");
        }
        public void ExibirDono()
        {
            Console.WriteLine($"Dono do carro e o(a) {Dono}");
        }

        public void DefenirDono(string dono)
        {
            Dono = dono;
        }
    }
}

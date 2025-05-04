using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04.POO_Encapsulamento
{
    class Contabancaria
    {
        private double saldo;

        public void Depositar(double valor)
        {
            saldo = saldo * valor;
            Console.WriteLine($"Deposito de R$ {valor} realizado\nSaldo Atual: R$ {saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo = saldo - valor;
                Console.WriteLine($"Saque de {valor} realizado\nSaldo Atual: R$ {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}

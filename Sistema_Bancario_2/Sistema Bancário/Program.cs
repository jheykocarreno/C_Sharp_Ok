using System.Diagnostics.Contracts;
using System.Drawing;
using System.Runtime.CompilerServices;

interface IContaBancaria
{
    void Depositar(double valor);
    bool Sacar(double valor);
    void MostrarSaldo();
}

class ContaBancaria : IContaBancaria
{
    private double saldo;
    private static int proximoNumero = 1;
    public int NumeroConta;
    public string Titular;
    public string Senha;
    public List<int> movimento = new List<int>();

    public ContaBancaria(string titular, string senha)
    {
        Titular = titular;
        Senha = senha;
        NumeroConta = proximoNumero++;
        saldo = 0;
    }

    public virtual void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine($"Depósito de R${valor:2F} realizado.\nSaldo atual: R${saldo:2F}");
    }

    public virtual bool Sacar(double valor) 
    { 
        if(valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
        else
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor:2F} realizado.\nSaldo atual: R${saldo:2F}");
            return true;
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Conta: {NumeroConta} | Titular: {Titular} | Saldo: R$ {saldo:2F}");
    }
}

class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(string titular, string senha) : base(titular, senha) { }

    public override void Depositar(double valor)
    {
        double bonus = valor * 0.01;
        base.Depositar(valor + bonus);
        Console.WriteLine($"Bônus de R$ {bonus:2F} adicionado!");
    }
}

class ContaCorrente : ContaBancaria
{
    public ContaCorrente(string titular, string senha) : base(titular, senha) { }
    
    public override bool Sacar(double valor)
    {
        double taxa = 2.50;
        if(valor + taxa > 0)
        {
            bool sacou = base.Sacar(valor + taxa);
            if (sacou)
            {
                Console.WriteLine($"Taxa de saque de R$ {taxa:2F} aplicada");
            }
            return sacou;
        } 
        return false;
    }
}

class Banco
{
    private List<ContaBancaria> contas = new List<ContaBancaria>();

    public void CriarConta()
    {
        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        Console.WriteLine(@$"
Escolha o tipo de conta 
1 - Corrente
2 - Poupança");
        Console.Write("> ");
        int tipo = int.Parse(Console.ReadLine());

        ContaBancaria novaConta = tipo == 1 ? new ContaCorrente(titular, senha) : new ContaPoupanca(titular, senha);

        contas.Add(novaConta);
        Console.WriteLine($"Conta {novaConta.NumeroConta} criada com sucesso!\n");
    }

    private ContaBancaria BuscarConta(int numeroContaDigitado)
    {
        return contas.Find(conta => conta.NumeroConta == numeroContaDigitado);

    }

    public void Depositar()
    {
        Console.WriteLine("Digite o numero da conta");
        Console.Write("> ");
        int numeroContaDigitado = int.Parse(Console.ReadLine());

        ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

        if (contaBuscada != null)
        {
            Console.WriteLine("Digite o valor do deposito");
            Console.Write("> ");
            double valor = double.Parse(Console.ReadLine());
            contaBuscada.Depositar(valor);
        }
        else
        {
            Console.WriteLine("Conta não encontrada");
        }
    }

    public void Sacar()
    {
        Console.WriteLine("Digite o numero da conta");
        Console.Write("> ");
        int numeroContaDigitado = int.Parse(Console.ReadLine());

        ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

        if (contaBuscada != null)
        {
            Console.WriteLine("Digite o valor do saque");
            Console.Write("> ");
            double valor = double.Parse(Console.ReadLine());
            contaBuscada.Sacar(valor);
        }
        else
        {
            Console.WriteLine("Conta não encontrada");
        }
    }

    public void Listar()
    {
        if (contas.Count > 0)
        {
            foreach (var conta in contas)
            {
                conta.MostrarSaldo();
            }
        }
        else
        {
            Console.WriteLine("Nenhuma conta cadastrada");
        }
    }

    public void Transferencia()
    {
        Console.WriteLine("Digite o numero de conta de saida: ");
        Console.Write("> ");
        int numeroContaDigitado = int.Parse(Console.ReadLine());

        ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

        if (contaBuscada != null)
        {
            Console.WriteLine("Inserir sua senha");
            Console.Write("> ");
            string senha = Console.ReadLine();

            if (senha == contaBuscada.Senha)
            {
                Console.WriteLine("Digite o numero de conta destino: ");
                Console.Write("> ");
                int numeroContaDigitado2 = int.Parse(Console.ReadLine());

                ContaBancaria contaBuscada2 = BuscarConta(numeroContaDigitado2);

                if (contaBuscada2 != null)
                {
                    Console.WriteLine("Digite o valor da transferencia");
                    Console.Write("> ");
                    double valor = double.Parse(Console.ReadLine());
                    contaBuscada.Sacar(valor);
                    contaBuscada2.Depositar(valor);
                }
                else
                {
                    Console.WriteLine("Conta destino não encontrada");
                }
            } else
            {
                Console.WriteLine("Senha incorreta");
            }
        }
        else
        {
            Console.WriteLine("Conta não encontrada");
        }
    }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco();
        int opcao;
        do
        {
            Console.WriteLine($@"
====== Sistema Bancário ======
1 - Criar Conta
2 - Depositar
3 - Sacar
4 - Listar Contas
5 - Transfencia entre contas
0 - Sair");
            Console.Write("> ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    banco.CriarConta();
                    break;
                case 2:
                    banco.Depositar();
                    break;
                case 3:
                    banco.Sacar();
                    break;
                case 4:
                    banco.Listar();
                    break;
                case 5:
                    banco.Transferencia();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}
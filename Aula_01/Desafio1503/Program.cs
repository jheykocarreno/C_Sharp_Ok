// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Desafio 15/03 - Accesso a informações governamentais
const string usuario = "usuario";
const string senha = "senha";
int cont = 3;
bool accessoOk = false;
int idadeEnt;

do
{
    Console.WriteLine("USUARIO: ");
    string usuEnt = Console.ReadLine();
    Console.WriteLine("SENHA: ");
    string senhaEnt = Console.ReadLine();

    if (usuario != usuEnt || senha != senhaEnt)
    {
        cont--;
        Console.WriteLine($"Usuario ou senha incorreto, quedam {cont} intentos");
        
        if (cont == 0)
        {
            Console.WriteLine("Numero de intentos exedido, Bye");
        }
    }else
    {
        accessoOk = true;
    }

} while (cont != 0 && accessoOk == false);

if (accessoOk == true)
{
    Console.WriteLine("Ingresse sua idade: ");
    idadeEnt = Convert.ToInt32(Console.ReadLine());
    char nivelEnt1;
    char nivelEnt2;

    if (idadeEnt < 18)
    {
        bool selOk = false;

        do
        {
            Console.WriteLine("Escolher 1 nivel: 1, 2 ou 3");
            nivelEnt1 = Convert.ToChar(Console.ReadLine());

            switch (nivelEnt1)
            {
                case '1':
                    Console.WriteLine("Selecionou Nivel 1");
                    selOk = true;
                    break;
                case '2':
                    if (idadeEnt < 18)
                    {
                        Console.WriteLine("1 Erro: Nivel para maiores de 18 anos");
                    }
                    break;
                case '3':
                    if (idadeEnt < 21)
                    {
                        Console.WriteLine("2 Erro: Nivel para maiores de 21 anos");
                    }
                    break;
                default:
                    Console.WriteLine("Nivel incorreto, somente 1, 2 ou 3");
                    break;
            }
        } while (selOk == false);

        Console.WriteLine($"Nivel 1: {nivelEnt1}");
    }
    else
    {
        bool selOk = false;

        do
        {
            Console.WriteLine("Escolher 2 dos 3 niveis: 1, 2 ou 3");
            Console.WriteLine("Primeiro nivel");
            nivelEnt1 = Convert.ToChar(Console.ReadLine());

            switch (nivelEnt1)
            {
                case '1':
                    Console.WriteLine("Selecionou Nivel 1");
                    selOk = true;
                    break;
                case '2':
                    if (idadeEnt < 18)
                    {
                        Console.WriteLine("3 Erro: Nivel para maiores de 18 anos");
                    }
                    else
                    {
                        Console.WriteLine("Selecionou Nivel 2");
                        selOk = true;
                    }
                    break;
                case '3':
                    if (idadeEnt < 21)
                    {
                        Console.WriteLine("4 Erro: Nivel para maiores de 21 anos");
                    }
                    else
                    {
                        Console.WriteLine("Selecionou Nivel 3");
                        Console.WriteLine("Inserir senha adicional Obrigatoria");
                        string senhaAdicional = Console.ReadLine();
                        selOk = true;
                    }
                    break;
                default:
                    break;
            }
        } while (selOk == false);
        
        selOk = false;
        
        do
        {
            Console.WriteLine("Segundo nivel"); 
            nivelEnt2 = Convert.ToChar(Console.ReadLine());

            switch (nivelEnt2)
            {
                case '1':
                    if (nivelEnt1 == '1')
                    {
                        Console.WriteLine("Nivel já selecionado");
                    }
                    else
                    {
                        Console.WriteLine("Selecionou Nivel 1");
                        selOk = true;
                    }
                    break;
                case '2':
                    if (nivelEnt1 == '2')
                    {
                        Console.WriteLine("Nivel já selecionado");
                    }
                    else
                    {
                        if (idadeEnt < 18)
                        {
                            Console.WriteLine("5 Erro: Nivel para maiores de 18 anos");
                        }
                        else
                        {
                            Console.WriteLine("Selecionou Nivel 2");
                            selOk = true;
                        }
                    }
                    break;
                case '3':
                    if (nivelEnt1 == 3)
                    {
                        Console.WriteLine("Nivel já selecionado");
                    }
                    else
                    {
                        if (idadeEnt < 21)
                        {
                            Console.WriteLine("6 Erro: Nivel para maiores de 21 anos");
                        }
                        else
                        {
                            Console.WriteLine("Selecionou Nivel 3");
                            Console.WriteLine("Inserir senha adicional Obrigatoria");
                            string senhaAdicional = Console.ReadLine();
                            selOk = true;
                        }
                    }
                    break;
                default:
                    break;
            }
        } while (selOk == false);

        Console.WriteLine($"Nivel 1: {nivelEnt1}");
        Console.WriteLine($"Nivel 2: {nivelEnt2}");
    }
}
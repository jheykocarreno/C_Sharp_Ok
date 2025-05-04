using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

List<string> tarefas = new List<string>();
List<bool> statusTarefa = new List<bool>();

void exibirMenu()
{
    Console.WriteLine($@"
============ MENU ==========
==  1 - Adicionar Tarefa  ==
==  2 - Listar Tarefas    ==
==  3 - Concuclir Tarefa  ==
==  4 - Excluir Tarefa    ==
==  5 - Exibir Resumo     ==
==  6 - Sair do programa  ==
============================
Escolha uma opcão:
");
}

bool sairDoPrograma = false;

while (sairDoPrograma)
{
    exibirMenu();
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarTarefa();
            break;

        case "2":
            ListarTarefas();
            break;

        case "3":
            MarcarComoConcluida();
            break;

        case "4":
            ExcluirTarefa();
            break;
            
        case "5":
            ExibirResumo();
            break;
            
        case "6":
            sairDoPrograma = true;
            Console.WriteLine("Saindo do programa...");
            break;
        
        default:
            Console.WriteLine("OPCAO INVALIDA! LEIA O MENU!");
            break;
    }
}

void AdicionarTarefa()
{
    Console.WriteLine("Digite uma nova Tarefa");
    string novaTarefa = Console.ReadLine();
    tarefas.Add(novaTarefa);
    statusTarefa.Add(false);
    Console.WriteLine("Tarefa adiciona com sucesso");
}

void ListarTarefas()
{
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada");
        return;
    }

    Console.WriteLine("\n==== LISTA DE TAREFAS ====");

    for (int i = 0; i < tarefas.Count; i++)
    {
        string status = statusTarefa[i] ? "Concluida" : "Pendente";
        Console.WriteLine($"{i + 1} - {tarefas[i]} | {status}");
    }
}

void MarcarComoConcluida()
{
    ListarTarefas();

    if(tarefas.Count == 0) return;

    Console.WriteLine("Digite o numero da tarefa concluida: ");
    int indice = int.Parse(Console.ReadLine()) - 1;

    if (indice >= 0 && indice < tarefas.Count)
    {
        statusTarefa[indice] = true;
        Console.WriteLine("Tarefa marcada como concluida");
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
}

void ExcluirTarefa()
{
    ListarTarefas();
    if (tarefas.Count == 0) return ;

    Console.WriteLine("Digite o numero da tarefa a ser excluida: ");
    int indice = int.Parse(Console.ReadLine()) - 1;

    if (indice >= 0 &&indice < tarefas.Count)
    {
        tarefas.RemoveAt(indice);
        statusTarefa.RemoveAt(indice);
        Console.WriteLine("Tarefa removida com sucesso!");
    }
    else
    { 
        Console.WriteLine("Numero invalido");
    }
}

void ExibirResumo()
{
    int total = tarefas.Count;
    int concluidas = statusTarefa.FindAll(status => status).Count();

    //foreach (bool x in statusTarefa) {      // outra maneira de fazer o findAll
    //    if (x) {
    //        Console.WriteLine("Concluida");
    //    }
    //}

    int pendentes = total - concluidas;

    Console.WriteLine($@"
    ========== RESUMO ==========
    Total de tarefas: {total}
    Concluidas: {concluidas}
    Pendentes: {pendentes}
    ");
}

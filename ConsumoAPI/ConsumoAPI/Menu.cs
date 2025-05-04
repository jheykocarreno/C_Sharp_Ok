public class Menu
{
    private bool rodando;

    public Menu()
    {
        rodando = true;
    }

    public string mostrarMenu()
    {
        Console.WriteLine($@"
#########################################
#           Buscador de Países          #
#########################################
#     Digite o país que deseja buscar   #");
        Console.Write("# > ");

        string resposta = Console.ReadLine();

        return resposta;
    }
}
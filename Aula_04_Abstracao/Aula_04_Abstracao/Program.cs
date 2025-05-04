IVeiculo meuCarro = new meuCarro();
meuCarro.mover();

IVeiculo minhaBike = new minhaBicicleta();
minhaBike.mover();

interface IVeiculo
{
    void mover();
}

class meuCarro : IVeiculo
{
    public void mover()
    {
        Console.WriteLine("O carro está andando na estrada");
    }
}

class minhaBicicleta : IVeiculo
{
    public void mover()
    {
        Console.WriteLine("A bicicleta está pedalando na ciclovia");
    }
}
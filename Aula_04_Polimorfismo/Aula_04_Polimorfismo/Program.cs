Carro meuCarro = new Carro();
Aviao meuAviao = new Aviao();
Trator trator = new Trator();

meuCarro.Mover();
meuAviao.Mover();
trator.Mover();

class Veiculo
{
    public string cor;
    public string ano;
    public string marca;
    public string modelo;

    public virtual void Mover()
    {
        Console.WriteLine("O veiculo está se movendo");
    }
}
class Carro : Veiculo
{
    public override void Mover()
    {
        base.Mover();
        Console.WriteLine("O carro está andando na estrada!");
    }
}

class Aviao : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O avião está voando no céu!");
    }
}

class Trator : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O trator está anda na chácara");
    }
}
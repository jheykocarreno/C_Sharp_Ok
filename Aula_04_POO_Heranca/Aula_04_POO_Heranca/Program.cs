Cachorro cachorro = new Cachorro { Nome = "Maya" };
//cachorro.Nome = "Fido";
cachorro.Respirar();
cachorro.Latir();

Gato gato = new Gato();
gato.Nome = "Morte";
gato.Respirar();
gato.Miar();

class Animal
{
    public string Nome;

    public void Respirar()
    {
        Console.WriteLine($"{Nome} está respirando");
    }
}

class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"{Nome} está latindo: Au Au");
    }
}

class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine($"{Nome} esta miando: Miau Miau");
    }
}

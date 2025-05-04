using Aula_04.Classes;

int valor = 0;

Carro meuCarro = new Carro();

meuCarro.ExibirInfo();

meuCarro.Marca = "Toyota";
meuCarro.Cor = "Azul";

meuCarro.ExibirInfo();

meuCarro.DefenirDono("Nelson");
meuCarro.ExibirDono();

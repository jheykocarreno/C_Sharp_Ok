using System;

public class JogoDaVelha
{
    private bool fimDeJogo;
    private char[] posicoes;
    private char vez;
    private int quantidadePreenchida;

    public JogoDaVelha()
    {
        fimDeJogo = false;
        posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        vez = 'X';
        quantidadePreenchida = 0;
    }

    public void Iniciar()
    {
        while (!fimDeJogo)
        {
            RenderizarTabela();
            LerEscolhaDoUsuario();
            RenderizarTabela();
            VerificarFimDeJogo();
            MudarVez();
        }
    }

    private void MudarVez()
    {
        vez = vez == 'X' ? 'O' : 'X';
    }

    private void VerificarFimDeJogo()
    {
        if (quantidadePreenchida < 5) { return; }

        if (ExisteVitoriaHorizontal() || ExisteVitoriaVertical() || ExisteVitoriaDiagonal())
        {
            Console.WriteLine($"FIM DO JOGO!!!\n Vitória do {vez}");
            fimDeJogo = true;
            return;
        }

        if (quantidadePreenchida is 9)
        {
            Console.WriteLine("FIM DE JOGO!!! DEU VELHA!");
            fimDeJogo= true;
        }
    }

    private bool ExisteVitoriaHorizontal()
    {
        bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[0] == posicoes[2];
        bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[3] == posicoes[5];
        bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[6] == posicoes[8];

        return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
    }

    private bool ExisteVitoriaVertical()
    {
        bool vitoriaColuna1 = posicoes[0] == posicoes[3] && posicoes[0] == posicoes[6];
        bool vitoriaColuna2 = posicoes[1] == posicoes[4] && posicoes[1] == posicoes[7];
        bool vitoriaColuna3 = posicoes[2] == posicoes[5] && posicoes[2] == posicoes[8];

        return vitoriaColuna1 || vitoriaColuna2 || vitoriaColuna3;
    }

    private bool ExisteVitoriaDiagonal()
    {
        bool vitoriaDiagonal1 = posicoes[0] == posicoes[4] && posicoes[0] == posicoes[8];
        bool vitoriaDiagonal2 = posicoes[2] == posicoes[4] && posicoes[2] == posicoes[6];

        return vitoriaDiagonal1 || vitoriaDiagonal2;
    }
    private void LerEscolhaDoUsuario()
    {
        Console.WriteLine($"Agora é a vez de {vez}, digite uma posição que esteja disponível (1 a 9)");
        Console.Write("> ");

        bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

        while (!conversao || !ValidarEscolhaUsuario(posicaoEscolhida))
        {
            Console.WriteLine("O campo escolhido é inválido! Digite uma posição que esteja disponível (1 a 9)");
            Console.Write("> ");
            conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
        }

        PreencherEscolha(posicaoEscolhida);
    }

    private void PreencherEscolha(int posicaoEscolhida)
    {
        int indice = posicaoEscolhida - 1;

        posicoes[indice] = vez;
        quantidadePreenchida++;
    }

    private bool ValidarEscolhaUsuario(int posicaoEscolhida)
    {
        int indice = posicaoEscolhida - 1;

        if (indice < 0 || indice > 8)
        {
            return false;
        }

        return posicoes[indice] != 'X' && posicoes[indice] != 'O';
    }

    private void RenderizarTabela()
    {
        Console.Clear();
        Console.WriteLine(ObterTabela());
    }

    private string ObterTabela()
    {
        return $@"
[{posicoes[0]}] | [{posicoes[1]}] | [{posicoes[2]}]
---------------
[{posicoes[3]}] | [{posicoes[4]}] | [{posicoes[5]}]
---------------
[{posicoes[6]}] | [{posicoes[7]}] | [{posicoes[8]}]";
    }
}

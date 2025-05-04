using System;

public class JogoDaVelha
{
    private bool fimDeJogo;
    private char[] posicoes;
    private char vez;1
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

    private void RenderizarTabela()
    {
        Console.Clear ();  
        cw
    }   
}
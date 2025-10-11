using System;

class program
{
    static void Main()
    {
        int[] pontuacoes = {95, 150, 180, 220, 300};
        int recorde = EncontrarMaiorPontuacao(pontuacoes);
        Console.WriteLine($"A maior pontuação é {recorde}");
    }

    static int EncontrarMaiorPontuacao(int[] pontuacoes)
    {
        int maiorPontuacao = pontuacoes[0];
        foreach (int pontos in pontuacoes)
            if (pontos > maiorPontuacao)
            {
                maiorPontuacao = pontos;
                Console.WriteLine($"Novo recorde: {maiorPontuacao}");
            }
            return maiorPontuacao;
    }
}
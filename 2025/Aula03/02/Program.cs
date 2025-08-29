using System;

class Exercicio1
{
    static void Main(string[] args)
    {
        double mediaFinal = 5.5;

        Console.WriteLine($"A média final do aluno é: {mediaFinal}");

        if (mediaFinal >= 7.0)
        {
            Console.WriteLine("Resultado: Aprovado! Parabéns!");
        }
        else
        {
            Console.WriteLine("Resultado: Reprovado. Estude mais.");
        }
    }
}

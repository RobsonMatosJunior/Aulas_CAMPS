// ## Cálculo do Perímetro de um Círculo (Usando Constantes) ##

using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite a velocidade em km/h: ");
        float velocidadeKmh = float.Parse(Console.ReadLine());

        float velocidadeMs = velocidadeKmh / 3.6f;
        Console.WriteLine($"A velocidade em m/s é: {velocidadeMs}");
    }
}

/* 
    Conversão de Velocidade de km/h para m/s

    Objetivo: Escrever um programa que converta uma velocidade de km/h para m/s.
*/
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
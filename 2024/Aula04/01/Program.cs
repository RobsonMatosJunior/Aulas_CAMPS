/*
    Cálculo da Área de um Retângulo

    Objetivo: Criar um programa que calcule a área de um retângulo com base na largura e altura fornecidas pelo usuário.
*/

using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite a largura do retângulo: ");
        float largura = float.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        float altura = float.Parse(Console.ReadLine());

        float area = largura * altura;
        Console.WriteLine($"A área do retângulo é: {area}");
    }
}

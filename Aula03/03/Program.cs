/* 
    Cálculo do Perímetro de um Círculo (Usando Constantes)

    Objetivo: Criar um programa que calcule o perímetro de um círculo, utilizando a constante PI.
*/ 

using System;
class Program
{
    const double PI = 3.14159;

    static void Main()
    {
        Console.Write("Digite o raio do círculo: ");
        float raio = float.Parse(Console.ReadLine());

        double perimetro = 2 * PI * raio;
        Console.WriteLine($"O perímetro do círculo é: {perimetro}");
    }
}

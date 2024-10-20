// ## Tabuada: Escreva um programa que imprima a tabuada de um número digitado pelo usuário.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

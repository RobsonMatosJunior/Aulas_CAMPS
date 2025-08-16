// ## Números Pares: Crie um programa que imprima os números pares de 1 a 20.

using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
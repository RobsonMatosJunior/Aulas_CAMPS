
using System;
using System.Collections.Generic;

class Ex01
{
    static void Main()
    {
        double[] notas = { 8.0, 7.5, 10.0, 9.5 };
        ExibirNotas(notas);
    }
    static void ExibirNotas(double[] notasFuncao)
    {
        foreach (double nota in notasFuncao)
        {
            Console.WriteLine($"{nota:F2}");
        }
    }
}
using System;
using System.Collections.Generic;

class Ex02
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 10, 15, 20 };
        int resultadoSoma = CalcularSoma(numeros);
        Console.WriteLine($"A soma dos números é: {resultadoSoma}");
    }
    
    static int CalcularSoma(List<int> numeros)
    {
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        return soma;
    }
}

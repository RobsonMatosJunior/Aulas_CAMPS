// ## Algoritmo para Calcular a Média de Três Notas ##

using System;
class Program
{
    static void Main()
    {
        // Solicitar ao usuário as notas
        Console.WriteLine("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média
        double media = (nota1 + nota2 + nota3) / 3;

        // Exibir a média
        Console.WriteLine($"A média das notas é: {media}");
    }
}
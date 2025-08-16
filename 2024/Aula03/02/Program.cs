// ## Algoritmo para Converter Temperatura de Celsius para Fahrenheit ##

using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (9.0 / 5.0) * celsius + 32;
        Console.WriteLine($"{celsius} graus Celsius é igual a {fahrenheit} graus Fahrenheit.");
    }
}
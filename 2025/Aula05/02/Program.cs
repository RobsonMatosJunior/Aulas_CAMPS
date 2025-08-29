using System;

class Exercicio2
{
static void Main(string[] args)
{
CalcularDobro(5);
CalcularDobro(10);
CalcularDobro(25);
}

// Função que recebe um número inteiro e mostra o seu dobro
static void CalcularDobro(int numero)
{
int resultado = numero * 2;
Console.WriteLine($"O dobro de {numero} é {resultado}");
}
}

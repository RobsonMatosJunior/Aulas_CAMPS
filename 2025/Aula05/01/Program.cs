using System;

class Exercicio1
{
static void Main(string[] args)
{
Console.WriteLine("Carregando o sistema...");
ExibirMenu(); // Primeira chamada

Console.WriteLine("\Voltando ao menu principal...");
ExibirMenu(); // Segunda chamada
}
// Função que apenas exibe o menu
static void ExibirMenu()
{
Console.WriteLine("--- Menu Principal ---");
Console.WriteLine("1. Iniciar Jogo");
Console.WriteLine("2. Opções");
Console.WriteLine("3. Sair");
}
}

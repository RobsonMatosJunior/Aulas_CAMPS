using System;

class Exercicio1
{
    static void Main(string[] args)
    {
        string nomeSujo = "  ana maria  ";
        string nomeLimpo = FormatarNome(nomeSujo);

        Console.WriteLine($"Nome original: '{nomeSujo}'");
        Console.WriteLine($"Nome formatado: '{nomeLimpo}'");
    }

    // Função que limpa e formata um nome
    static string FormatarNome(string nome)
    {
        string nomeFormatado = nome.Trim().ToUpper();
        return nomeFormatado;
    }
}

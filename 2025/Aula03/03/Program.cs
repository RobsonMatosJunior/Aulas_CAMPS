using System;

class Exercicio3
{
    static void Main(string[] args)
    {
        int idadeParaFilme = 10;

        Console.WriteLine($"Idade do espectador: {idadeParaFilme} anos.");

        if (idadeParaFilme >= 18)
        {
            Console.WriteLine("Recomendado: Filme de ação/terror.");
        }
        else if (idadeParaFilme >= 12)
        {
            Console.WriteLine("Recomendado: Filme de aventura/super-herói.");
        }
        else
        {
            Console.WriteLine("Recomendado: Filme de animação/desenho.");
        }
    }
}
.
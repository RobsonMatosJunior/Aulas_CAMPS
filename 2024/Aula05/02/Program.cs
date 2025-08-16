// ## Aprovação de Aluno: Determine se um aluno foi aprovado ou reprovado com base em uma nota.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do aluno: ");
        float nota = float.Parse(Console.ReadLine());

        if (nota >= 6)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
/*
using System;	-> Permite usar classes básicas como Console
using System.Collections.Generic; -> Permite usar coleções como List<T>
class "Arrays"	-> Estrutura obrigatória para organizar o código
static void Main()	-> Ponto de partida da execução do programa
*/

using System;

class Arrays
{
    static void Main()
    {
        // Criando um array de 3 números inteiros
        int[] numeros = new int[3];

        numeros[0] = 10; // O primeiro elemento está no índice 0
        numeros[1] = 20;
        numeros[2] = 30;

        // Acessando os elementos do array
        Console.WriteLine($"{numeros[0]} \n{numeros[1]} \n{numeros[2]}");

        // Forma mais curta de criar e inicializar
        string[] alunos = { "Ryan", "Danilo", "Heloise" };

        // Acessando os elementos do array
        Console.WriteLine($"\n{alunos[0]} \n{alunos[1]} \n{alunos[2]}\n");

        string[] nomes = { "Ana", "Carlos", "Bia" };
        for (int i = 0; i < nomes.Length; i++) // .Length é o tamanho do array
        {
            Console.WriteLine($"O nome no índice {i} é {nomes[i]}");
        }
    }
}

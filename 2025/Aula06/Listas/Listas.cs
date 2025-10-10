/*
using System;	-> Permite usar classes básicas como Console
using System.Collections.Generic; -> Permite usar coleções como List<T>
class "Listas"	-> Estrutura obrigatória para organizar o código
static void Main()	-> Ponto de partida da execução do programa
*/

using System;
using System.Collections.Generic;

class Listas
{
    static void Main()
    {

        // Criando uma lista de strings
        List<string> nomes = new List<string>();

        // Adicionando itens
        nomes.Add("Ryan");
        nomes.Add("Danilo");
        nomes.Add("Heloise");

        // Acessando os elementos da lista
        Console.WriteLine($"{nomes[0]} \n{nomes[1]} \n{nomes[2]}");

        // Removendo um item
        nomes.Remove("Danilo");

        // Acessando os elementos da lista
        Console.WriteLine($"\n{nomes[0]} \n{nomes[1]} \n");

        List<double> notas = new List<double> { 10, 7.5, 9 };
        foreach (double nota in notas)
        {
            Console.WriteLine($"Nota: {nota}");
        }

    }
}
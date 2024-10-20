/*
    Funções e Listas: Criaremos uma função que adiciona tarefas a uma lista (adicionar e listar tarefas).
*/

using System;
using System.Collections.Generic;

class Program
{
    // Função para adicionar uma tarefa à lista
    static void AdicionarTarefa(List<string> tarefas) {
        Console.Write("Digite a nova tarefa: ");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada!");
    }

    // Função para exibir todas as tarefas
    static void MostrarTarefas(List<string> tarefas) {
        Console.WriteLine("\nTarefas:");
        foreach (string tarefa in tarefas) {
            Console.WriteLine("- " + tarefa);
        }
    }

    static void Main() {
        List<string> tarefas = new List<string>();

        // Adicionar algumas tarefas e mostrar a lista
        AdicionarTarefa(tarefas);  // Adiciona a primeira tarefa
        AdicionarTarefa(tarefas);  // Adiciona a segunda tarefa
        
        MostrarTarefas(tarefas);   // Exibe todas as tarefas
    }
}

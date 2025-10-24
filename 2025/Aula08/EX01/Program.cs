using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crie a pilha
        Stack<string> pilhaDePratos = new Stack<string>();

        // 2. Coloque pratos na pilha
        Empilhar(pilhaDePratos, "Prato Azul");
        Empilhar(pilhaDePratos, "Prato Vermelho");
        Empilhar(pilhaDePratos, "Prato Verde"); // 'Verde' é o último a entrar (Last-In)

        Console.WriteLine("\n--- Hora de Lavar ---");
        
        // 3. Lave os pratos (na ordem LIFO)
        LavarProximo(pilhaDePratos); // 'Verde' deve ser o primeiro a sair (First-Out)
        LavarProximo(pilhaDePratos); // 'Vermelho' sai em seguida
        LavarProximo(pilhaDePratos); // 'Azul' sai por último
        LavarProximo(pilhaDePratos); // A pilha agora está vazia
    }

    // Função para adicionar um item no TOPO (Push)
    static void Empilhar(Stack<string> pilha, string prato)
    {
        pilha.Push(prato);
        Console.WriteLine($"'{prato}' foi colocado no topo da pilha.");
    }

    // Função para remover um item do TOPO (Pop)
    static void LavarProximo(Stack<string> pilha)
    {
        if (pilha.Count > 0)
        {
            string prato = pilha.Pop();
            Console.WriteLine($"Lavando o '{prato}' (que estava no topo).");
        }
        else
        {
            Console.WriteLine("[INFO] A pilha de pratos está limpa!");
        }
    }
}
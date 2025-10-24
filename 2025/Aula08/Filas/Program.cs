using System;
// 1. Precisamos desta biblioteca para usar a Queue (Fila)
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 2. Crie a "Fila" (Queue)
        Queue<string> filaDeAtendimento = new Queue<string>();

        Console.WriteLine("--- Fila Abrindo ---");

        // 3. Para ADICIONAR (Entrar no FIM da Fila), usamos Enqueue()
        Console.WriteLine("Ana chegou (1ª).");
        filaDeAtendimento.Enqueue("Ana"); // Ana é a primeira a entrar

        Console.WriteLine("Bruno chegou (2º).");
        filaDeAtendimento.Enqueue("Bruno");

        Console.WriteLine("Carla chegou (3ª).");
        filaDeAtendimento.Enqueue("Carla");

        Console.WriteLine($"\nQuem é o primeiro da fila agora? {filaDeAtendimento.Peek()}");
        Console.WriteLine($"Total na fila: {filaDeAtendimento.Count}");

        Console.WriteLine("\n--- Começando Atendimento ---");

        // 4. Para REMOVER (Pegar do INÍCIO da Fila), usamos Dequeue()
        // A Ana deve sair primeiro, pois foi a primeira a entrar (First-In, First-Out)
        string clienteAtendido1 = filaDeAtendimento.Dequeue();
        Console.WriteLine($"Atendendo: {clienteAtendido1}"); // Saída da Ana

        string clienteAtendido2 = filaDeAtendimento.Dequeue();
        Console.WriteLine($"Atendendo: {clienteAtendido2}"); // Saída do Bruno
        
        string clienteAtendido3 = filaDeAtendimento.Dequeue();
        Console.WriteLine($"Atendendo: {clienteAtendido3}"); // Saída da Carla

        // A fila agora está vazia
        Console.WriteLine($"\nTotal na fila: {filaDeAtendimento.Count}");
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Crie a fila
        Queue<string> filaDeAtendimento = new Queue<string>();

        // 2. Pessoas entram na fila
        AdicionarPessoa(filaDeAtendimento, "Ana"); // 'Ana' é a primeira a entrar (First-In)
        AdicionarPessoa(filaDeAtendimento, "Bruno");
        AdicionarPessoa(filaDeAtendimento, "Carla");

        Console.WriteLine("\n--- Hora de Atender ---");

        // 3. Atenda as pessoas (na ordem FIFO)
        AtenderProximo(filaDeAtendimento); // 'Ana' deve ser a primeira a sair (First-Out)
        AtenderProximo(filaDeAtendimento); // 'Bruno' sai em seguida
        AtenderProximo(filaDeAtendimento); // 'Carla' sai por último
        AtenderProximo(filaDeAtendimento); // A fila agora está vazia
    }

    // Função para adicionar um item no FIM (Enqueue)
    static void AdicionarPessoa(Queue<string> fila, string nome)
    {
        fila.Enqueue(nome);
        Console.WriteLine($"'{nome}' entrou no fim da fila.");
    }

    // Função para remover um item do INÍCIO (Dequeue)
    static void AtenderProximo(Queue<string> fila)
    {
        if (fila.Count > 0)
        {
            string pessoa = fila.Dequeue();
            Console.WriteLine($" Atendendo '{pessoa}' (que estava no início).");
        }
        else
        {
            Console.WriteLine("[INFO] A fila de atendimento está vazia!");
        }
    }
}
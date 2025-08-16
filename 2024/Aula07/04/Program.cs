using System; 
// Importa o namespace System, que contém classes fundamentais para manipulação de entrada e saída.

using System.Collections.Generic; 
// Importa o namespace System.Collections.Generic, que contém classes para coleções genéricas, como Queue, List, e outras.

class Program { 
// Define a classe Program, que contém o método Main e representa a estrutura do programa.

    static void Main() 
    { 
    // Método Main, que é o ponto de entrada do programa onde a execução começa.

        Queue<string> fila = new Queue<string>(); 
        // Cria uma nova instância da classe Queue para armazenar strings, representando uma fila.

        fila.Enqueue("primeiro"); 
        // Adiciona o elemento "primeiro" ao final da fila.

        fila.Enqueue("segundo"); 
        // Adiciona o elemento "segundo" ao final da fila.

        fila.Dequeue(); 
        // Remove e descarta o elemento que está no início da fila (que é "primeiro").

        Console.WriteLine($"Elemento restante na fila: {fila.Peek()}"); 
        // Imprime o elemento que está no início da fila (que agora é "segundo"), sem removê-lo.
    }
}
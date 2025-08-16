using System; 
// Importa o namespace System, que contém classes fundamentais para manipulação de entrada e saída, incluindo a classe Console.

using System.Collections.Generic; 
// Importa o namespace System.Collections.Generic, que contém classes para coleções genéricas, como pilhas, filas e listas.

class Program { 
// Define a classe Program, que contém o método Main e representa a estrutura do programa.

    static void Main() { 
    // Método Main, que é o ponto de entrada do programa onde a execução começa.

        Stack<string> pilha = new Stack<string>(); 
        // Declara e inicializa uma nova pilha de strings, que é uma coleção que segue a lógica LIFO (Last In, First Out).

        pilha.Push("primeiro"); 
        // Adiciona o elemento "primeiro" ao topo da pilha.

        pilha.Push("segundo"); 
        // Adiciona o elemento "segundo" ao topo da pilha, acima do elemento "primeiro".

        pilha.Push("terceiro"); 
        // Adiciona o elemento "terceiro" ao topo da pilha, acima dos elementos "primeiro" e "segundo".

        pilha.Pop(); 
        // Remove o elemento do topo da pilha (que é "terceiro"), mas não o imprime.

        Console.WriteLine($"Elemento no topo da pilha: {pilha.Peek()}"); 
        // Imprime o elemento no topo da pilha (que agora é "segundo") sem removê-lo, usando interpolação de string.
    } 
} 

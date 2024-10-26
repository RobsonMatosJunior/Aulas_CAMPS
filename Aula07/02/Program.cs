using System; 
// Importa o namespace System, que contém classes fundamentais para manipulação de entrada e saída, incluindo a classe Console.

using System.Collections.Generic; 
// Importa o namespace System.Collections.Generic, que contém classes para coleções genéricas, como listas e dicionários.

class Program { 
// Define a classe Program, que contém o método Main e representa a estrutura do programa.

    static void Main() { 
    // Método Main, que é o ponto de entrada do programa onde a execução começa.

        List<string> lista = new List<string>(); 
        // Declara e inicializa uma nova lista de strings.

        lista.Add("maçã"); 
        // Adiciona o elemento "maçã" à lista.

        lista.Add("banana"); 
        // Adiciona o elemento "banana" à lista.

        lista.Add("laranja"); 
        // Adiciona o elemento "laranja" à lista.

        Console.WriteLine($"Tamanho da lista: {lista.Count}"); 
        // Imprime o tamanho da lista usando interpolação de string, que retorna a contagem de elementos na lista.
    }
}
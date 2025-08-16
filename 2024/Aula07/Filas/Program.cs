using System; 
// Importa o namespace System, que contém classes básicas de entrada e saída.
using System.Collections.Generic; 
// Importa o namespace para coleções genéricas, como Queue.

class Fila 
// Define a classe Fila, que representa a estrutura de dados fila.
{ 
    private Queue<string> fila = new Queue<string>();
    // Declara e inicializa uma fila de strings.

    // Método para adicionar um elemento ao final da fila
    public void Adicionar(string elemento) 
    {
        fila.Enqueue(elemento); 
        // Utiliza a operação Enqueue para adicionar o elemento à fila.
    }

    // Método para remover e retornar o elemento do início da fila
    public string Remover() 
    {
        return fila.Dequeue();
        // Utiliza a operação Dequeue para remover e retornar o elemento do início da fila.
    }

    // Método para retornar o elemento do início sem removê-lo
    public string Frente() 
    {
        return fila.Peek();
        // Utiliza a operação Peek para retornar o elemento do início sem removê-lo.
    }

    // Método para verificar se a fila está vazia
    public bool Vazia() 
    {
        return fila.Count == 0;
        // Retorna true se a contagem de elementos na fila for zero, indicando que está vazia.
    }
}

class Program 
 // Classe principal do programa.
{
    static void Main() 
     // Método Main, ponto de entrada do programa.
    {
        Fila minhaFila = new Fila(); 
        // Cria uma nova instância da classe Fila chamada minhaFila.
        minhaFila.Adicionar("cliente1"); 
        // Adiciona "cliente1" à fila.
        minhaFila.Adicionar("cliente2"); 
        // Adiciona "cliente2" à fila.

        Console.WriteLine(minhaFila.Frente());
        // Saída: cliente1 (retorna o primeiro elemento da fila).
        Console.WriteLine(minhaFila.Remover());
        // Saída: cliente1 (remove e retorna o primeiro elemento da fila).
        Console.WriteLine(minhaFila.Vazia());
        // Saída: False (verifica se a fila está vazia).
    }
}
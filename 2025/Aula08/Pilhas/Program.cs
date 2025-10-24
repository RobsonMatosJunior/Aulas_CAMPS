using System;
// 1. Precisamos desta biblioteca para usar a Stack (Pilha)
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 2. Crie a "Pilha" (Stack). Ela começa vazia.
        Stack<string> pilhaDePratos = new Stack<string>();

        Console.WriteLine($"Itens na pilha agora: {pilhaDePratos.Count}");

        // 3. Para ADICIONAR (Entrar no Topo), usamos Push()
        Console.WriteLine("\n'Ana' (Prato 1) chegou e foi colocada no topo.");
        pilhaDePratos.Push("Ana");
        
        // 4. Agora podemos espiar. Quem está no topo!
        // (É a 'Ana', pois é a única)
        string topoDaPilha = pilhaDePratos.Peek();
        Console.WriteLine($"Quem está no topo é: {topoDaPilha}. (Tamanho pilha: {pilhaDePratos.Count})");

        // 5. Para ADICIONAR DE NOVO, usamos Push()
        Console.WriteLine("\n'Bruno' (Prato 2) chegou e foi colocado no topo.");
        pilhaDePratos.Push("Bruno"); // 'Bruno' é o "Last-In" (Último a Entrar)

        // 6. Agora podemos espiar novamente.
        // (Agora é o 'Bruno', pois ele foi o último a entrar)
        topoDaPilha = pilhaDePratos.Peek(); // Atualizamos a variável
        Console.WriteLine($"Quem está no topo é: {topoDaPilha}. (Tamanho pilha: {pilhaDePratos.Count})");
    }
}
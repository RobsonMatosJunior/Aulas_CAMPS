using System;
using System.Collections.Generic;
/*
    using System;: Inclui o namespace System, que contém classes fundamentais, como a classe Console, usada para entrada e saída no console.
    using System.Collections.Generic;: Inclui o namespace System.Collections.Generic, que fornece classes para coleções genéricas, como Stack<T>.
*/

class Pilha {
    private Stack<string> pilha = new Stack<string>();

    // Adiciona um elemento ao topo da pilha
    public void Adicionar(string elemento) {
        pilha.Push(elemento);
    }

    // Remove e retorna o elemento do topo da pilha
    public string Remover() {
        return pilha.Pop();
    }

    // Retorna o elemento do topo sem removê-lo
    public string Topo() {
        return pilha.Peek();
    }

    // Verifica se a pilha está vazia
    public bool Vazia() {
        return pilha.Count == 0;
    }

    // Remove todos os elementos da pilha
    public void Limpar() {
        pilha.Clear();
    }

    // Retorna o número de elementos na pilha
    public int Contar() {
        return pilha.Count;
    }

    // Converte a pilha em um array
    public string[] ParaArray() {
        return pilha.ToArray();
    }
}

class Program {
    static void Main() 
    /*
        class Program: Define a classe principal chamada Program, onde o ponto de entrada do programa será implementado.
        static void Main(): Define o método Main, que é o ponto de entrada do programa C#. É o primeiro método executado quando o programa é iniciado.
    */
    {
        Pilha minhaPilha = new Pilha();
        //Cria uma nova instância da classe Pilha chamada minhaPilha.
        
        minhaPilha.Adicionar("primeiro");
        minhaPilha.Adicionar("segundo");
        //minhaPilha.Adicionar("primeiro"): Adiciona o elemento "primeiro" ao topo da pilha.
        //minhaPilha.Adicionar("segundo"): Adiciona o elemento "segundo" ao topo da pilha, que agora é o novo topo.
        
        Console.WriteLine(minhaPilha.Topo()); 
        // Chama o método Topo da pilha para obter o elemento do topo e exibi-lo no console. A saída será "segundo". 
        //Saída: segundo
        
        Console.WriteLine(minhaPilha.Remover()); 
        //Chama o método Remover para remover e retornar o elemento do topo, que é "segundo", e exibi-lo no console.
        // Saída: segundo

        Console.WriteLine(minhaPilha.Vazia()); 
        //Chama o método Vazia para verificar se a pilha está vazia e exibe o resultado. Como ainda há um elemento na pilha, a saída será False.
        // Saída: False

        minhaPilha.Limpar();
        Console.WriteLine(minhaPilha.Vazia());
        //Chama o método Vazia novamente para verificar se a pilha está vazia após a limpeza e exibe o resultado.
        // Agora, a saída será True, pois a pilha foi esvaziada.
    }
}

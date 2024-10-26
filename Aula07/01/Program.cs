using System;
// Importa o namespace System, que contém classes fundamentais para manipulação de entrada e saída, como a classe Console.

class Program 
// Define a classe Program, que contém o método Main e representa a estrutura do programa.

{ 
    static void Main() 
    // Método Main, que é o ponto de entrada do programa onde a execução começa.

    { 
        int[] arrayNumeros = { 10, 20, 30, 40, 50 };
        // Declara e inicializa um array de inteiros com cinco elementos: 10, 20, 30, 40 e 50.

        Console.WriteLine("Elementos do array:");
        // Imprime uma mensagem no console para indicar que os elementos do array serão exibidos.

        Console.WriteLine(arrayNumeros[0]);
        // Acessa e imprime o primeiro elemento do array (índice 0), que é 10.

        Console.WriteLine(arrayNumeros[1]);
        // Acessa e imprime o segundo elemento do array (índice 1), que é 20.

        Console.WriteLine(arrayNumeros[2]);
        // Acessa e imprime o terceiro elemento do array (índice 2), que é 30.

        Console.WriteLine(arrayNumeros[3]);
        // Acessa e imprime o quarto elemento do array (índice 3), que é 40.

        Console.WriteLine(arrayNumeros[4]);
        // Acessa e imprime o quinto elemento do array (índice 4), que é 50.
    } 
}
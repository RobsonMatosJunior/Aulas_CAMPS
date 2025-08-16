/*
    Funções e Arrays: Criaremos uma função que receba um array de cinco notas e retorne a média dessas notas.
*/

using System;

class Program {
    static void Main() {
        // Array de notas
        int[] notas = { 7, 8, 9, 6, 10 };

        // Chama a função CalcularMedia e armazena o resultado
        float media = CalcularMedia(notas);

        // Exibe o resultado na tela
        Console.WriteLine($"A média das notas é: {media}");
    }

    // Função que calcula a média das notas
    static float CalcularMedia(int[] notas) {
        int soma = 0;
        
        // Loop para somar todas as notas
        for (int i = 0; i < notas.Length; i++) {
            soma += notas[i];
        }

        // Retorna a média das notas
        return (float)soma / notas.Length;
    }
}

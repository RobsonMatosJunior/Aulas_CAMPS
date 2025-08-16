using System; 
// Importa o namespace System, para funcionalidades básicas.
using System.Collections.Generic;
// Importa o namespace System.Collections.Generic para trabalhar com coleções genéricas como List.

class Program
// Declaração da classe principal chamada Program.
{
    static void Main() 
    // Método Main é o ponto de entrada do programa.
    {
        // Chama o método para criar a lista e armazena o retorno em 'lista'
        List<string> lista = CriarLista();

        // Adiciona itens na lista usando o método Add
        lista.Add("Item 1");
        lista.Add("Item 2");
    }

    static List<string> CriarLista()
    // Declara o método CriarLista que retorna uma lista de strings
    {
        return new List<string>(); 
    }
}

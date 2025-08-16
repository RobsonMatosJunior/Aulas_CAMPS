/*
    Funções e Listas: Criaremos uma função que adiciona tarefas a uma lista (adicionar e listar tarefas).
*/

using System; 
// Importa o namespace System, que contém classes fundamentais para manipulação de entrada e saída.

using System.Collections.Generic; 
// Importa o namespace System.Collections.Generic, que contém classes para coleções genéricas, como List.

class Program 
// Define a classe Program, que contém o método Main e representa a estrutura do programa.
{ 
    static void AdicionarTarefa(List<string> tarefas) 
    // 'static' permite chamar a função sem instanciar a classe, útil para funções que não precisam de dados específicos de um objeto.
    // 'void' indica que a função não retorna nenhum valor; apenas executa a ação de adicionar uma tarefa à lista.
    { 
        Console.Write("Digite a nova tarefa: "); 
        // Solicita ao usuário que digite uma nova tarefa.

        string tarefa = Console.ReadLine(); 
        // Lê a entrada do usuário e armazena na variável tarefa.

        tarefas.Add(tarefa); 
        // Adiciona a nova tarefa à lista de tarefas.

        Console.WriteLine("Tarefa adicionada!"); 
        // Confirma que a tarefa foi adicionada com sucesso.
    }

    static void MostrarTarefas(List<string> tarefas) 
    // 'static' permite chamar a função sem criar uma instância da classe; útil para funções que não dependem de dados de um objeto.
    // 'void' indica que a função não retorna valor; apenas exibe a lista de tarefas.
    { 
        Console.WriteLine("\nTarefas:"); 
        // Exibe um cabeçalho para a lista de tarefas.

        // Exibe cada tarefa individualmente, acessando os elementos da lista pelo índice.
        for (int i = 0; i < tarefas.Count; i++) { 
            // Percorre a lista de tarefas usando um loop for.

            Console.WriteLine("- " + tarefas[i]); 
            // Imprime cada tarefa precedida de um traço, formatando a saída.
        }
    }

    static void Main()
    // Método Main, que é o ponto de entrada do programa onde a execução começa.

    { 

        List<string> tarefas = new List<string>(); 
        // Cria uma nova instância da classe List para armazenar as tarefas como strings.

        AdicionarTarefa(tarefas); 
        // Chama a função AdicionarTarefa para permitir que o usuário adicione uma nova tarefa.

        AdicionarTarefa(tarefas); 
        // Chama a função AdicionarTarefa novamente para adicionar outra tarefa.

        MostrarTarefas(tarefas); 
        // Chama a função MostrarTarefas para exibir todas as tarefas adicionadas.
    }
}

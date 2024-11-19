public class Pessoa 
{
    // Propriedade pública 'Nome' com get e set automáticos
    public string Nome { get; set; }
    
    // Propriedade pública 'Idade' com get e set automáticos
    public int Idade { get; set; }

    // Método para exibir as informações da pessoa
    public void ExibirInformacoes()
    // Exibe o nome e a idade da pessoa, utilizando interpolação de string
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}"); // Exibe os valores das propriedades Nome e Idade
    }
}
public class Program
{
    public static void Main()
    {
        // Instancia um novo objeto da classe Pessoa e define os valores para Nome e Idade
        Pessoa pessoa = new Pessoa { Nome = "João", Idade = 30 };

        // Chama o método ExibirInformacoes do objeto 'pessoa', que exibe os valores de Nome e Idade

        pessoa.ExibirInformacoes();
        // Exibe: Nome: João, Idade: 30
    }
}
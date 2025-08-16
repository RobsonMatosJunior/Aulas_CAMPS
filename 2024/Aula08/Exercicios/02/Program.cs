public class Animal
// Propriedade pública 'Nome' com get e set automáticos
{
    public string Nome { get; set; }
    // Método que exibe um som genérico de animal

    public void EmitirSom()
    {
        Console.WriteLine("Som de animal");  // Exibe a mensagem "Som de animal" no console
    }
}

public class Cachorro : Animal
// Método específico para o cachorro latir
{
    public void Latir() 
    // Exibe a mensagem "Au Au" no console
    {
        Console.WriteLine("Au Au");
    }
}

public class Gato : Animal
// Método específico para o gato miar
{   
    public void Miar() 
    {
        Console.WriteLine("Miau");
        // Exibe a mensagem "Miau" no console
    }
}

public class program
{
    public static void Main(string[] args)
    {
        // Instanciando um objeto da classe Cachorro e atribuindo o nome "Max"
        Cachorro cachorro = new Cachorro { Nome = "Max" };

        // Chamando o método EmitirSom da classe Animal (herdado por Cachorro)
        // Isso exibe "Som de animal", pois o método é herdado da classe base
        cachorro.EmitirSom();  
        // Saída: Som de animal

        // Chamando o método Latir, que é específico da classe Cachorro
        // Isso exibe "Au Au" no console
        cachorro.Latir();
        // Saída: Au Au

        // Instanciando um objeto da classe Gato e atribuindo o nome "Luna"
        Gato gato = new Gato { Nome = "Luna" };

        // Chamando o método EmitirSom da classe Animal (herdado por Gato)
        // Isso exibe "Som de animal", pois o método é herdado da classe base
        gato.EmitirSom();
        // Saída: Som de animal

        // Chamando o método Miar, que é específico da classe Gato
        // Isso exibe "Miau" no console
        gato.Miar();
        // Saída: Miau
    }
}
public class Animal
// Método virtual que pode ser sobrescrito em classes derivadas
{
    public virtual void EmitirSom() 
    {
        Console.WriteLine("O animal faz um som."); 
        // Exibe uma mensagem padrão se o método não for sobrescrito
    }
}

public class Cachorro : Animal
// Sobrescrita do método EmitirSom na classe Cachorro

{
    public override void EmitirSom() 
    {
        Console.WriteLine("Cachorro: AU AU, Corinthians vai cair ");
        // Sobrescreve o método para exibir o som de um cachorro
    }
}

public class Gato : Animal
// Sobrescrita do método EmitirSom na classe Gato
{
    public override void EmitirSom() 
    {
        Console.WriteLine("Gato: Miau, e a copa do brasil?");
        // Sobrescreve o método para exibir o som de um gato
    }
}


class Program
{
    static void Main(){
    // Instanciando um Cachorro como Animal
    Animal meuCachorro = new Cachorro();
    // Instanciando um Cachorro como Animal. Isso é possível por polimorfismo.

    Animal meuGato = new Gato();
    // Instanciando um Gato como Animal. Isso também é possível por polimorfismo.

    // Aqui, o método EmitirSom será chamado para cada tipo de animal, mas o comportamento variará de acordo com a classe.
    meuCachorro.EmitirSom();
    // Saída: Au Au. O comportamento de EmitirSom é sobrescrito pela classe Cachorro

    meuGato.EmitirSom();
    // Saída: Miau. O comportamento de EmitirSom é sobrescrito pela classe Gato
    
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        // Instanciando um Cachorro como Animal

        Animal meuCachorro = new Cachorro();
        // Instanciando um Cachorro como Animal. Isso é possível por polimorfismo.

        Animal meuGato = new Gato();
        // Instanciando um Gato como Animal. Isso também é possível por polimorfismo.

        // Aqui, o método EmitirSom será chamado para cada tipo de animal, mas o comportamento variará de acordo com a classe.
        meuCachorro.EmitirSom();
        // Saída: Au Au. O comportamento de EmitirSom é sobrescrito pela classe Cachorro

        meuGato.EmitirSom();
        // Saída: Miau. O comportamento de EmitirSom é sobrescrito pela classe Gato

    }
}


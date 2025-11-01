class Program
{
    static void Main()
    {
        // 1. CRIAR OS OBJETOS (chama o construtor)
        Carro meuFusca = new Carro("Fusca", "Azul");
        Carro suaFerrari = new Carro("Ferrari F50", "Vermelha");

        // 2. ACESSAR AS PROPRIEDADES (com o PONTO)
        Console.WriteLine($"Meu carro é um {meuFusca.Modelo} da cor {meuFusca.Cor}.");
        Console.WriteLine($"Seu carro é um {suaFerrari.Modelo} da cor {suaFerrari.Cor}.");

        // 3. CHAMAR OS MÉTODOS (com o PONTO)
        meuFusca.Ligar();  // "O Fusca está ligando!"
        suaFerrari.Ligar(); // "O Ferrari F50 está ligando!"
    }
}

// Classe Carro
class Carro
{
    // Propriedades
    public string Modelo { get; set; }
    public string Cor { get; set; }

    // Construtor
    public Carro(string modelo, string cor)
    {
        Modelo = modelo;
        Cor = cor;
    }

    // Método
    public void Ligar()
    {
        Console.WriteLine($"O {Modelo} está ligando!");
    }
}

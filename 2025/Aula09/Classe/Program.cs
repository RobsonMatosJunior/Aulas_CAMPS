class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }

    // Construtor
    public Carro(string modelo, string cor)
    {
        // 'this.Modelo' é a Propriedade
        // 'modelo' é o parâmetro recebido
        this.Modelo = modelo; 
        this.Cor = cor;
    }

    // ... Métodos ...
}
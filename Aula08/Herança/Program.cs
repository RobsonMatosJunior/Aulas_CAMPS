public class Veiculo 
{
    private string marca;
    // Atributo privado que armazena a marca do veículo. Ele não pode ser acessado diretamente fora da classe.
    // Propriedade "Marca" que permite acessar e modificar o valor do atributo privado "marca".
    // O método "get" retorna o valor de "marca", e o "set" define um novo valor para "marca".

    public string Marca 
    {
        get { return marca; }
        // Quando a propriedade "Marca" for acessada, retorna o valor do atributo "marca".
        set { marca = value; }
        // Quando um valor for atribuído à propriedade "Marca", esse valor será armazenado no atributo "marca".
    }

    // Método público que simula a aceleração do veículo.
    public void Acelerar() 
    {
        Console.WriteLine("O veículo está acelerando.");
        // Exibe a mensagem informando que o veículo está acelerando.
    }
}

// Definição da classe "Carro", que herda da classe "Veiculo". 
// Isso significa que "Carro" tem todas as propriedades e métodos de "Veiculo", incluindo a propriedade "Marca" e o método "Acelerar".
public class Carro : Veiculo 
{
    public int NumeroDePortas { get; set; }
    // Propriedade pública que define e acessa o número de portas do carro.
}

// Definição da classe "Motocicleta", que também herda da classe "Veiculo".
// "Motocicleta" tem as mesmas propriedades e métodos de "Veiculo", mas pode adicionar suas próprias características.
public class Motocicleta : Veiculo 
{
    public bool TemCarona { get; set; }
    // Propriedade pública que define se a motocicleta pode ou não levar um passageiro.
}

// Instanciando um objeto da classe "Carro" e atribuindo valores às suas propriedades "Marca" e "NumeroDePortas".
Carro carro = new Carro { Marca = "Toyota", NumeroDePortas = 4 };

// Instanciando um objeto da classe "Motocicleta" e atribuindo valores às suas propriedades "Marca" e "TemCarona".
Motocicleta moto = new Motocicleta { Marca = "Honda", TemCarona = true };

// Exibindo as informações do "Carro". Aqui acessamos a propriedade "Marca" e "NumeroDePortas" do objeto "carro".
Console.WriteLine($"Carro: {carro.Marca}, Portas: {carro.NumeroDePortas}");

// Chamando o método "Acelerar" do objeto "carro". Esse método é herdado da classe "Veiculo".
carro.Acelerar();  // Exibe a mensagem "O veículo está acelerando.".

// Exibindo as informações da "Motocicleta". Aqui acessamos a propriedade "Marca" e "TemCarona" do objeto "moto".
Console.WriteLine($"Motocicleta: {moto.Marca}, Tem Carona: {moto.TemCarona}");

// Chamando o método "Acelerar" do objeto "moto". Esse método também é herdado da classe "Veiculo".
moto.Acelerar();
// Exibe a mensagem "O veículo está acelerando.".
public class ContaBancaria 
{
    // Declaração de uma classe chamada ContaBancaria.
    // Essa classe serve para modelar uma conta bancária com saldo e operações básicas.
    
    private decimal saldo; 
    // Variável privada que armazena o saldo da conta, protegida contra acesso direto.

    public void Depositar(decimal valor) 
    // Método público que permite depositar um valor na conta.
    // Recebe um parâmetro "valor" do tipo decimal.
        
    {
        if (valor > 0)
        // Verifica se o valor é maior que zero antes de realizar o depósito.
        {
            saldo += valor;
            // Adiciona o valor ao saldo da conta.
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
            // Exibe uma mensagem de confirmação, mostrando o valor depositado formatado como moeda.
        }
    }

    public void ExibirSaldo() 
    // Método público para exibir o saldo atual da conta.
    {
        Console.WriteLine($"Saldo atual: {saldo:C}");
        // Exibe o saldo formatado como moeda, sem permitir acesso direto ao saldo fora da classe.
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        // Uso da classe ContaBancaria

        ContaBancaria conta = new ContaBancaria();
        // Cria uma nova instância (ou seja, um novo objeto) da classe ContaBancaria, chamada "conta".

        conta.Depositar(100.00m);
        // Chama o método Depositar para adicionar 100 à conta.
        // O "m" após o número indica que é um valor do tipo decimal.

        conta.ExibirSaldo();
        // Chama o método ExibirSaldo para mostrar o saldo atual na tela.
        // Este método acessa o saldo indiretamente e exibe: "Saldo atual: $100.00".
    }
}
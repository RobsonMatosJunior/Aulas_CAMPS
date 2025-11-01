using System;

class Program
{

    // Dentro da classe Program, no método Main

    static void Main(string[] args)
    {
        // 1. Criar o primeiro objeto Aluno
        Aluno aluno1 = new Aluno("Vinicius Santos", 8.0, 9.0);

        // 2. Criar o segundo objeto Aluno
        Aluno aluno2 = new Aluno("Luiz", 5.0, 6.0);

        // 3. Chamar os métodos de cada objeto
        aluno1.ExibirStatus();

        Console.WriteLine(); // Só para dar um espaço

        aluno2.ExibirStatus();
    }

}
class Aluno
{
    // 1. Propriedades
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    // 2. Construtor
    public Aluno(string nome, double n1, double n2)
    {
        this.Nome = nome;
        this.Nota1 = n1;
        this.Nota2 = n2;
    }

    // 3. Método para calcular a média
    public double CalcularMedia()
    {
        double media = (this.Nota1 + this.Nota2) / 2;
        return media;
    }

    // 4. Método para exibir o resultado
    public void ExibirStatus()
    {
        double mediaFinal = this.CalcularMedia();

        Console.WriteLine($"--- Aluno: {this.Nome} ---");
        Console.WriteLine($"Média: {mediaFinal}");

        if (mediaFinal >= 7.0)
        {
            Console.WriteLine("Status: APROVADO");
        }
        else
        {
            Console.WriteLine("Status: REPROVADO");
        }
    }
}
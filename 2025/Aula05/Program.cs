static void NomeDaFuncao()
{
    // Código que a função vai executar...
}

// Definição da função
static void ExibirMensagemDeBoasVindas() 
{ 
Console.WriteLine("-----------------------------");
Console.WriteLine("Bem-vindo ao nosso sistema!");
Console.WriteLine("-----------------------------");
}

---------------------------------------------------------

static void Main(string[] args)
{
// Chamando a função para ser executada
ExibirMensagemDeBoasVindas();

// Podemos chamar de novo!
Console.WriteLine("Iniciando o cadastro...");
ExibirMensagemDeBoasVindas();
}

---------------------------------------------------------

static void Main(string[] args)
{
SaudacaoPersonalizada("Maria"); // Envia o texto "Maria" para o parâmetro 'nome'
SaudacaoPersonalizada("Carlos");
}

---------------------------------------------------------


static int SomarDoisNumeros(int a, int b)
{
    int resultado = a + b;
    return resultado; // Devolve o resultado da soma
}

static void Main(string[] args)
{
    // Chama a função e guarda o valor retornado na variável 'soma'
    int soma = SomarDoisNumeros(10, 5);
    Console.WriteLine($"O resultado da soma é: {soma}");
}

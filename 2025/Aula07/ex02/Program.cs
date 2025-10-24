using System;

class Exercicio2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando senha 'senhafraca'...");
        bool teste1 = ValidarSenha("senhafraca");
        Console.WriteLine($"Resultado: {teste1}\n"); // Esperado: False

        Console.WriteLine("Testando senha 'SenhaForte!'...");
        bool teste2 = ValidarSenha("SenhaForte!");
        Console.WriteLine($"Resultado: {teste2}"); // Esperado: True
    }

    // Função que valida uma senha com regras simples
    static bool ValidarSenha(string senha)
    {
        // Regra 1: Tamanho mínimo
        bool temTamanho = senha.Length >= 8;
        
        // Regra 2: Contém caractere especial
        bool temCaractere = senha.Contains("!");

        // Retorna true apenas se AMBAS as regras forem verdadeiras
        if (temTamanho && temCaractere)
        {
            return true;
        }
        else
        {
            return false;
        }
        
        // Versão curta (avançada):
        // return senha.Length >= 8 && senha.Contains("!");
    }
}
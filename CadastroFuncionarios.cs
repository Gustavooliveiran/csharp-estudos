using System;

class CadastroFuncionarios
{
    static void Main()
    {
        string[] funcionarios = 
        {
            "Carlos",
            "Ana",
            "Lucas"
        };

        Console.WriteLine("Funcionários cadastrados:");

        foreach (string funcionario in funcionarios)
        {
            Console.WriteLine(funcionario);
        }
    }

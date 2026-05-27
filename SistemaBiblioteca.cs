using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo;
    public string Autor;
    public bool Disponivel;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("\nTítulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Status: " + (Disponivel ? "Disponível" : "Emprestado"));
    }
}

class SistemaBiblioteca
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>();

        livros.Add(new Livro("Clean Code", "Robert Martin"));
        livros.Add(new Livro("Java Fundamentals", "James Gosling"));
        livros.Add(new Livro("Python para Dados", "Gustavo Oliveira"));

        while (true)
        {
            Console.WriteLine("\n===== SISTEMA BIBLIOTECA =====");
            Console.WriteLine("1 - Listar livros");
            Console.WriteLine("2 - Emprestar livro");
            Console.WriteLine("3 - Devolver livro");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                foreach (Livro livro in livros)
                {
                    livro.ExibirInformacoes();
                }
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o título do livro: ");

                string titulo = Console.ReadLine();

                foreach (Livro livro in livros)
                {
                    if (livro.Titulo.ToLower() == titulo.ToLower())
                    {
                        if (livro.Disponivel)
                        {
                            livro.Disponivel = false;
                            Console.WriteLine("Livro emprestado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Livro já está emprestado.");
                        }
                    }
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite o título do livro: ");

                string titulo = Console.ReadLine();

                foreach (Livro livro in livros)
                {
                    if (livro.Titulo.ToLower() == titulo.ToLower())
                    {
                        livro.Disponivel = true;
                        Console.WriteLine("Livro devolvido com sucesso!");
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Sistema encerrado.");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}

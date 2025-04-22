using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();
        int proximoId = 1;

        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Buscar produto por nome");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço do produto: ");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    Produto novo = new Produto
                    {
                        Id = proximoId++,
                        Nome = nome,
                        Preco = preco
                    };

                    produtos.Add(novo);
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Produtos Cadastrados ---");
                    foreach (Produto p in produtos)
                    {
                        Console.WriteLine(p);
                    }
                    break;

                case "3":
                    Console.Write("Digite o nome para busca: ");
                    string busca = Console.ReadLine().ToLower();
                    var encontrados = produtos.FindAll(p => p.Nome.ToLower().Contains(busca));

                    Console.WriteLine($"\n--- Resultados para \"{busca}\" ---");
                    if (encontrados.Count > 0)
                    {
                        foreach (var p in encontrados)
                            Console.WriteLine(p);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum produto encontrado.");
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
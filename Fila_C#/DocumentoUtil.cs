using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Queue<Documento> filaImpressao = new Queue<Documento>();

        while (true)
        {
            Console.WriteLine("\n--- Spool de Impressão ---");
            Console.WriteLine("1 - Adicionar documento à fila");
            Console.WriteLine("2 - Visualizar próximo da fila");
            Console.WriteLine("3 - Imprimir próximo documento");
            Console.WriteLine("4 - Listar todos os documentos na fila");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do documento: ");
                    string nome = Console.ReadLine();

                    Console.Write("Número de páginas: ");
                    int paginas = Convert.ToInt32(Console.ReadLine());

                    filaImpressao.Enqueue(new Documento { Nome = nome, Paginas = paginas });
                    Console.WriteLine("Documento adicionado à fila!");
                    break;

                case "2":
                    if (filaImpressao.Count > 0)
                        Console.WriteLine("Próximo: " + filaImpressao.Peek());
                    else
                        Console.WriteLine("Fila vazia.");
                    break;

                case "3":
                    if (filaImpressao.Count > 0)
                    {
                        Documento doc = filaImpressao.Dequeue();
                        Console.WriteLine("Imprimindo: " + doc);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum documento na fila.");
                    }
                    break;

                case "4":
                    Console.WriteLine("--- Fila de Impressão ---");
                    if (filaImpressao.Count > 0)
                    {
                        foreach (var d in filaImpressao)
                            Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine("Fila vazia.");
                    }
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
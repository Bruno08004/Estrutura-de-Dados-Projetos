using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        string textoAtual = "";

        while (true)
        {
            Console.WriteLine("\nTexto atual: " + textoAtual);
            Console.WriteLine("1 - Digitar novo texto");
            Console.WriteLine("2 - Desfazer (Undo)");
            Console.WriteLine("3 - Refazer (Redo)");
            Console.WriteLine("4 - Visualizar histórico (Undo Stack)");
            Console.WriteLine("5 - Limpar histórico");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o novo texto: ");
                    undoStack.Push(textoAtual);
                    textoAtual = Console.ReadLine();
                    redoStack.Clear();
                    break;

                case "2":
                    if (undoStack.Count > 0)
                    {
                        redoStack.Push(textoAtual);
                        textoAtual = undoStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Nada para desfazer.");
                    }
                    break;

                case "3":
                    if (redoStack.Count > 0)
                    {
                        undoStack.Push(textoAtual);
                        textoAtual = redoStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Nada para refazer.");
                    }
                    break;

                case "4":
                    Console.WriteLine("\n--- Histórico (Undo Stack) ---");
                    if (undoStack.Count > 0)
                    {
                        foreach (var item in undoStack)
                            Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine("Histórico vazio.");
                    }
                    break;

                case "5":
                    undoStack.Clear();
                    redoStack.Clear();
                    textoAtual = "";
                    Console.WriteLine("Histórico limpo com sucesso!");
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}

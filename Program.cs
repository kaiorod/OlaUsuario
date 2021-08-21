using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Clear();
            Console.Beep();
            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();
            
            Console.Beep();
            Console.Write("Olá, ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"{nome}");
            Console.ResetColor();
            Console.Write("!");
            
        }
    }
}

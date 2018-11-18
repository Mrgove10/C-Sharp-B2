using System;
namespace Exercice_9_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tapez Ctrl+C pour quitter l'application.");

            Game game = new Game(new FakeConsole());
            game.Start();

            Console.ReadLine();
        }
    }
}
using System;
using Exercice_9_1;
namespace Exercice_9_1.Fake
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
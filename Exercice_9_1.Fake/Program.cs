using System;
using Exercice_9_1.Dll;
namespace Exercice_9_1.Fake
{
    public class Program
    {
        /// <summary>
        /// Fonction main de test de l'application
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Tapez Ctrl+C pour quitter l'application.");

            Game game = new Game(new FakeConsole(), new FakeRandom());
            game.Start();

            Console.ReadLine();
        }
    }
}
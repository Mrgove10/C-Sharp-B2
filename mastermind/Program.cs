using System;

namespace mastermind
{
    internal class Program
    {
        /// <summary>
        /// Boule principale
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Jeu MainGame = new Jeu(); //creates now game
            MainGame.MainStart(); // launches it
            Console.ReadLine(); // Prevents console shutting down at the end
        }
    }
}
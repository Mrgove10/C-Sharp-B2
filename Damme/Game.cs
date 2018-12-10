using System;

namespace Damme
{
    internal class Game
    {
        public void StartGame()
        {
            PlayfieldGenerator PG = new PlayfieldGenerator();
            var t = PG.GeneratePlayField(10);
            DisplayManager screen = new DisplayManager();
            screen.GridView(t);
            Console.ReadLine();
        }
    }
}
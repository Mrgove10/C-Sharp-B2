using Damme.Interfaces;
using System;

namespace Damme.Classes
{
    public class DisplayManager : IDisplay
    {
        /// <summary>
        /// Generates the 2D view of the playing field
        /// </summary>
        /// <param name="field">Field to display</param>
        public void GridView(Pion[,] field)
        {
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int x = 0; x < 10; x++)
            {
                Console.Write(x + 1 + " ");
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(field[x, y].PlayerSign + " ");
                }
                Console.Write("\n"); //line return char
            }
        }
    }
}
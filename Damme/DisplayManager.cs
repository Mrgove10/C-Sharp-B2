using System;

namespace Damme
{
    internal class DisplayManager
    {
        /// <summary>
        /// Generates the 2D view of the playing field
        /// </summary>
        /// <param name="field">Field to display</param>
        public void GridView(Pion[,] field)
        {
            Console.WriteLine("  a b c d e f g h i j");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + " ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(field[i, j].signe + " ");
                }
                Console.Write("\n"); //line return char
            }
        }
    }
}
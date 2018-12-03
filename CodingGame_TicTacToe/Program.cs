/*using System;
using System.Collections.Generic;

namespace CodingGame_TicTacToe
{
    public class Player
    {
        private static void Main(string[] args)
        {
            string[] inputs;
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int opponentRow = int.Parse(inputs[0]);
                int opponentCol = int.Parse(inputs[1]);
                int validActionCount = int.Parse(Console.ReadLine()); //nombres de cases libre sur le tableau (renvoyer par l'ia)
                Random rand = new Random();
                // int select = rand.Next(0, validActionCount);
                List<string> PossiblePlays = new List<string>();
                for (int i = 0; i < validActionCount; i++)
                {
                    PossiblePlays.Add(Console.ReadLine());

                }
                Console.WriteLine(PossiblePlays[0]);
            }
        }
    }

    public class Case
    {
        public int row;
        public int colomn;
        public bool isTaken;

        public Case(int r, int c)
        {
            row = r;
            colomn = c;
        }
    }
}*/
using System;

namespace Damme
{
    public class Game
    {
        public void StartGame()
        {
            PlayfieldGenerator PG = new PlayfieldGenerator();
            DisplayManager screen = new DisplayManager();
            Utils utilities = new Utils();
            bool Game = true;
            char currentplayer = '0';

            while (Game)
            {
                Console.Clear();
                Pion[,] mainPlayingField = PG.GeneratePlayField(10);
                screen.GridView(mainPlayingField);
                Turn(currentplayer, mainPlayingField);
                currentplayer = switchplayer(currentplayer);

                Console.WriteLine("Appuyer sur entre pour passer au prochain tour");
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        public void Turn(char player, Pion[,] playField)
        {
            Utils utilities = new Utils();

            if (player == '0')//white
            {
                Console.WriteLine("Au tour de Blanc");
            }

            if (player == '1')//black
            {
                Console.WriteLine("Au tour de noir");
            }

            Console.WriteLine("Coordonne du pion a bougé [x y]");

            int[] coordinates = utilities.StringSpliter(Console.ReadLine());
            Pion thePion = playField[coordinates[0] - 1, coordinates[1] - 1];
            //    Console.WriteLine(thePion.x + "," + thePion.y + "," + thePion.signe); //Debug
        }

        public char switchplayer(char currentPlayerP)
        {
            if (currentPlayerP == '0')//white
            {
                return '1';
            }

            if (currentPlayerP == '1') //white
            {
                return '0';
            }

            return ' '; // error
        }
    }
}
using System;

namespace Damme
{
    public class Game
    {
        public void StartGame()
        {
            PlayfieldGenerator pg = new PlayfieldGenerator();
            DisplayManager screen = new DisplayManager();
            Utils utilities = new Utils();
            bool game = true;
            char currentplayer = '0';

            while (game)
            {
                Console.Clear();
                Pion[,] mainPlayingField = pg.GeneratePlayField(10);
                screen.GridView(mainPlayingField);
                Turn(currentplayer, mainPlayingField);
                currentplayer = SwitchPlayer(currentplayer);

                Console.WriteLine("Appuyer sur entre pour passer au prochain tour");
                Console.ReadLine();
            }
        }

        public char SwitchPlayer(char currentPlayerP)
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

        public void Turn(char player, Pion[,] playField)
        {
            ValidationEngine validation = new ValidationEngine();
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

            int[] coordinatesInitialPion = utilities.StringSpliter(Console.ReadLine());
            Pion thePion = playField[coordinatesInitialPion[0] - 1, coordinatesInitialPion[1] - 1];

            Console.WriteLine("Coordonne de destination [x y]");

            int[] coordinatesToMoveTo = utilities.StringSpliter(Console.ReadLine());
           var result =  validation.Validate(thePion, coordinatesToMoveTo[0], coordinatesToMoveTo[1], playField, player);
            Console.WriteLine(result);
            //    Console.WriteLine(thePion.x + "," + thePion.y + "," + thePion.signe); //Debug
        }
    }
}
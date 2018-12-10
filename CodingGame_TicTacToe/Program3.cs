namespace CodingGame_TicTacToe
{
    public class Game
    {
        public IConsole Console { get; set; }

        public Game(IConsole console)
        {
            Console = console;
        }

        private void Start()
        {
            while (true)
            {
                Turn();
            }
        }

        public string Turn()
        {
            Console.ReadLine().Split(' ');
            int validActionCount = int.Parse(Console.ReadLine());
            string selectAction = "";
            for (int i = 0; i < validActionCount; i++)
            {
                string line = Console.ReadLine();
                if (i == 0)
                {
                    selectAction = line;
                }
            }
            Console.WriteLine(selectAction);
            return selectAction;
        }

        public static void Main(string[] args)
        {
            Game MG = new Game(new TrueConsole());
            MG.Start();
            // game loop
        }
    }
}
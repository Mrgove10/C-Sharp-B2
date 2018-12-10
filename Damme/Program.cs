namespace Damme
{
    public class Program
    {
        /// <summary>
        /// This is the main entry point to the application.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IConsole Console = new TrueConsole();
            Game Maingame = new Game(Console);
            Maingame.StartGame();
        }
    }
}
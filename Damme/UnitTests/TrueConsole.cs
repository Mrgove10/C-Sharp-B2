using System;

namespace Damme
{
    public class TrueConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string outputString)
        {
            Console.WriteLine(outputString);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
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

        public void WriteErrorLine(string outputString)
        {
            Console.Error.WriteLine(outputString);
        }
    }
}
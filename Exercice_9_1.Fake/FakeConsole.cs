    using System;
    using Exercice_9_1;
namespace Exercice_9_1

{
    internal class FakeConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
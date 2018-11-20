using System;
using Exercice_9_1.Dll;
namespace Exercice_9_1.Fake
{
    /// <summary>
    /// implementation d'une interface console
    /// </summary>
    public class FakeConsole : IConsole
    {
        /// <summary>
        /// lis la ligne actuele
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// ecrit une ligne
        /// </summary>
        /// <param name="input">text a ecrire</param>
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
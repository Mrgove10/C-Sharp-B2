using System;

namespace Damme.Classes
{
    public class Utils
    {
        /// <summary>
        /// Splits a string into two integers
        /// </summary>
        /// <param name="entryString">String to split</param>
        /// <returns>Array of two integers</returns>
        public int[] StringSpliter(string entryString)
        {
            int[] temp = new int[2];
            string[] stringTab = entryString.Split(' ');

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = Int32.Parse(stringTab[i]);
            }
            return temp;
        }
    }
}
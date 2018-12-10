using System;

namespace Damme
{
    internal class Utils
    {
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
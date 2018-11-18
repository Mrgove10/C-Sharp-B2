using System;
using System.Collections.Generic;
using System.Linq;

namespace Chiffrement
{
    internal class Cesar_Dechiffrement
    {
        private static string Alpha = "abcdefghijklmnopqrstuvwxyz";
        private List<char> Alphalist = Alpha.ToList();

        public string Decrypt(string DecryptString, int decalage)
        {
            string returnstr = "";
            foreach (char p in DecryptString)
            {
                if (p != ' ')
                {
                    returnstr += Alpha[(Alphalist.IndexOf(p) + 26 - Math.Abs(decalage)) % 26];
                }
                else
                {
                    returnstr += ' ';
                }
            }
            return returnstr;
        }
    }
}
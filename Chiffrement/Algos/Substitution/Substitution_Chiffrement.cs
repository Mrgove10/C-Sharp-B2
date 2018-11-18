using System.Collections.Generic;
using System.Linq;

namespace Chiffrement.Algos.Substitution
{
    internal class Substitution_Chiffrement
    {
        private static string Alpha = "abcdefghijklmnopqrstuvwxyz";
        private List<char> Alphalist = Alpha.ToList();


        public string Substitution(string StringToCrypt, string mot)
        {
            string returnstr = "";

            StringToCrypt = StringToCrypt.ToLower();

            var alpamod = "";

            alpamod += mot;

            //cree la chaine modifier
            foreach (char c in Alpha)
            {
                if (!mot.Contains(c))
                {
                    alpamod += c;
                }
            }

            foreach (char t in StringToCrypt)
            {
                if (t != ' ')
                {
                    int indexalpha = Alpha.IndexOf(t);
                    returnstr += alpamod[indexalpha];
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffrementCorrection
{
    public abstract class Cesar : ICesar
    {
        public abstract int CalculPosition(int positionLettre, int decalage);

        public string ChiffreOuDechiffreMot(string mot, int decalage)
        {
            string result = "";

            foreach (char caractere in mot)
            {
                result += ChiffreOuDechiffreLettre(caractere.ToString(), decalage);
            }

            return result;
        }

        protected string ChiffreOuDechiffreLettre(string lettre, int decalage)
        {
            List<string> alphabet = "abcdefghijklmnopqrstuvwxyz"
                                    .Select(e => e.ToString())
                                    .ToList();

            int positionLettre = alphabet.IndexOf(lettre);
            Console.WriteLine("Position de  " + lettre + " : " + positionLettre);

            positionLettre = CalculPosition(positionLettre, decalage);

            string lettreChiffree = alphabet[positionLettre];
            Console.WriteLine("Lettre chiffrée : " + lettreChiffree);

            return lettreChiffree;
        }

    }
}

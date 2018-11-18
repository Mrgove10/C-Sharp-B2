using System.Collections.Generic;
using System.Linq;

namespace Chiffrement.Algos.Cesar
{
    public abstract class Cesar
    {
        public abstract int CalculePosition(int PositionLettre, int Decalage);

        public string ChiffreOuDechiffreLettre(string StringToCrypt, int Decalage)
        {
            string Alpha = "abcdefghijklmnopqrstuvwxyz";
            List<char> Alphalist = Alpha.ToList();

            string returnstr = "";

            StringToCrypt = StringToCrypt.ToLower();

            foreach (char p in StringToCrypt)
            {
                if (p == ' ')
                {
                    returnstr += ' ';
                }
                else
                {
                    int place = Alphalist.IndexOf(p);
                    int placemod = CalculePosition(place, Decalage);

                    returnstr += Alphalist[placemod];
                }
            }

            return returnstr;
        }
    }
}
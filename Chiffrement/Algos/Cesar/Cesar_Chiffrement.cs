using Chiffrement.Algos.Cesar;
using System.Collections.Generic;
using System.Linq;

namespace Chiffrement 
{
     class Cesar_Chiffrement : Cesar
    {

        public override int CalculePosition(int PositionLettre, int Decalage)
        {
            return (PositionLettre + Decalage) % 26;
        }
    }
}
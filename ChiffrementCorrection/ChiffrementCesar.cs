using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffrementCorrection
{
    class ChiffrementCesar : Cesar
    {
        public override int CalculPosition(int positionLettre, int decalage)
        {
            return (positionLettre + decalage) % 26;
        }

    }
}

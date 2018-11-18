using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffrementCorrection
{
    public interface ICesar
    {
        string ChiffreOuDechiffreMot(string mot, int decalage);

    }
}

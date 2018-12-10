using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame_TicTacToe
{
    public interface IError
    {
        /// <summary>
        /// Writing in console method.
        /// </summary>
        /// <param name="outputString"></param>
        void WriteLine(string outputString);
    }
}

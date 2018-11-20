using Exercice_9_1.Dll;
using System;

namespace Exercice_9_1.Fake
{
    /// <summary>
    /// Implementation d'eune interface random
    /// </summary>
    public class FakeRandom : IRandom
    {
        /// <summary>
        /// retourn un nombre aleatoire
        /// </summary>
        /// <param name="min">borne infeieure</param>
        /// <param name="max">borne supperieure</param>
        /// <returns></returns>
        public int Next(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
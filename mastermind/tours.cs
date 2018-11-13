using System;
using System.Collections.Generic;

namespace mastermind
{
    public class Tour
    {
        public List<Pion> PionsTour = new List<Pion>();
        public List<Pion> Verif = new List<Pion>(4);

        /// <summary>
        /// Jouele tours d'un joueur
        /// </summary>
        /// <returns></returns>
        public Tour JouerTours()
        {
            Console.WriteLine("------- nouveau tours -------");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Couleur en position " + i + " :");
                string usercolor = Console.ReadLine();
                PionsTour.Add(new Pion(usercolor));
            }

            return this;
        }
    }
}
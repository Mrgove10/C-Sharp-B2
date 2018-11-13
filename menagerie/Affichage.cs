using System;
using System.Collections.Generic;

namespace menagerie
{
    internal class Affichage
    {
        /// <summary>
        /// Affichage de la position de chaque animal
        /// </summary>
        /// <param name="animal">IAnimal de l'animal en question</param>
        /// <param name="position">position actuel de l'animal</param>
        public void stringcreator(Animal animal, int position, int RaceLength)
        {
            char TerrainChar = '-';
            int StepsLeft = RaceLength - position;
            string t = "===I";
            for (int i = 1; i < RaceLength; i++)
            {
                if (i == position)
                {
                    t += "o";
                }
                else
                {
                    t += TerrainChar;
                }
            }

            t += "I===|nom : " + animal.Nom + "|pas restant : " + StepsLeft + "|" + animal.GetType().Name;

            Console.WriteLine(t);
        }

        /// <summary>
        /// Affichage de la liste des animaux
        /// </summary>
        /// <param name="ListAnimaux"></param>
        public void affichageList(List<Animal> ListAnimaux)
        {
            foreach (IAnimal An in ListAnimaux)
            {
                Console.WriteLine(An.GetType().Name + " , " + An.Nom + " , " + An.Cri);
            }
        }
    }
}
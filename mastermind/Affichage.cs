using System;
using System.Collections.Generic;

namespace mastermind
{
    public class Affichage
    {
        /// <summary>
        /// Affiche l'ascii art au demarage
        /// </summary>
        public void WelcomeScreen()
        {
            Console.WriteLine(@"    __  ___           __            __  ____           __");
            Console.WriteLine(@"   /  |/  /___ ______/ /____  _____/  |/  (_)___  ____/ /");
            Console.WriteLine(@"  / /|_/ / __ `/ ___/ __/ _ \/ ___/ /|_/ / / __ \/ __  / ");
            Console.WriteLine(@" / /  / / /_/ (__  ) /_/  __/ /  / /  / / / / / / /_/ /  ");
            Console.WriteLine(@"/_/  /_/\__,_/____/\__/\___/_/  /_/  /_/_/_/ /_/\__,_/   ");
            Console.WriteLine("Devinez la prediction de l'adversaire en moin de 12 tours");
            Console.WriteLine();
            Console.WriteLine("Les couleurs posisble sont : Bleu, Rouge, Vert, Jaune, Noir, Blanc");
            Console.WriteLine();
            Console.WriteLine("Appuiyer sur entrer pour jouer");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// affiche la liste de pions
        /// </summary>
        /// <param name="LP"></param>
        public void AffichageListePion(List<Pion> LP)
        {
            foreach (var Pion in LP)
            {
                AffichageCouleur(Pion);
            }
        }

        /// <summary>
        /// affichage d'un tours complet : pion et verification
        /// </summary>
        /// <param name="Tour"></param>
        public void AffichageTourComplet(List<Tour> Tour)
        {
            foreach (var touractu in Tour)
            {
                foreach (var Pion in touractu.PionsTour)
                {
                    AffichageCouleur(Pion);
                }
                Console.Write("        ");
                foreach (var Pion in touractu.Verif)
                {
                    AffichageCouleur(Pion);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Fonction d'affichage d'un seul pion en fonction de ca couleur
        /// </summary>
        /// <param name="P"></param>
        public void AffichageCouleur(Pion P)
        {
            if (P.ColorPion == Pion.Color.Blanc)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("█  ");
            }

            if (P.ColorPion == Pion.Color.Bleu)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("█  ");
            }

            if (P.ColorPion == Pion.Color.Noir)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("█  ");
            }

            if (P.ColorPion == Pion.Color.Jaune)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("█  ");
            }

            if (P.ColorPion == Pion.Color.Rouge)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("█  ");
            }

            if (P.ColorPion == Pion.Color.Vert)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("█  ");
            }
        }
    }
}
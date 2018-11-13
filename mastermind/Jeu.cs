using System;
using System.Collections.Generic;

namespace mastermind
{
    internal class Jeu
    {
        private Prediction MainPrediction = new Prediction(); //creationd'eun prediction par la machine
        private Affichage AffichageEngine = new Affichage(); //moteur d'affichage
        private Verification VerificationEngine = new Verification(); //moteur de verification

        private int NbToursRestant = 12;
        private bool GameOn;

        private List<Tour> ListToursJeuComplet = new List<Tour>(); // liste de tous les tours du jeu

        /// <summary>
        /// Boucle principale du jeu 
        /// </summary>
        public void MainStart()
        {
            AffichageEngine.WelcomeScreen();

            GameOn = true;
            while (GameOn)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Il vous reste " + NbToursRestant + " tours.");

                if (NbToursRestant <= 11)
                {
                    AffichageEngine.AffichageTourComplet(ListToursJeuComplet);
                    Console.WriteLine();
                }
                Console.ResetColor();
                Tour TourJoueur = new Tour();
                TourJoueur.JouerTours();
                VerificationEngine.verifTest(TourJoueur, MainPrediction);
                ListToursJeuComplet.Add(TourJoueur);

                if (VerificationEngine.IsAllGood(TourJoueur, MainPrediction))
                {
                    GameOn = false;
                    Console.WriteLine("Victoire ! vous avez gagner en " + (12 - NbToursRestant) + "tours");
                }
                Console.WriteLine("Appuiyer sur entrer pour passer au prochain tour");
                Console.ReadLine();

                NbToursRestant = NbToursRestant - 1;
                if (NbToursRestant <= 0)
                {
                    Console.WriteLine("Defaite, la prediction etais ");
                    AffichageEngine.AffichageListePion(MainPrediction.GetPrediction());
                    GameOn = false;
                }
                else
                {
                    GameOn = true;
                }
            }

            Console.WriteLine();
        }
    }
}
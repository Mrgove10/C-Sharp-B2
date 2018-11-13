using System;
using System.Collections.Generic;

namespace mastermind
{
    public class Prediction
    {
        private List<Pion> PredictionList; //Prediction initial de la machine

        /// <summary>
        /// Creeune prediction pour la machine
        /// </summary>
        public Prediction() //Constructeur
        {
            Random rand = new Random();
            PredictionList = new List<Pion>(); // Liste des pions constituant la prediction
            for (int i = 0; i < 4; i++)
            {
                Pion p = new Pion(rand.Next(0, 6));
                PredictionList.Add(p);
                //  Console.WriteLine(p.ColorPion); //DEBUG
            }
        }

        /// <summary>
        /// retourne la liste dela prediction sans la modifier (evite la triche)
        /// </summary>
        /// <returns></returns>
        public List<Pion> GetPrediction()
        {
            return PredictionList;
        }
    }
}